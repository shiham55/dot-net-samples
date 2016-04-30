using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using DataAccess;
using DataAccess.Respository;
using DataAccess.ShopModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Shop.Models;

namespace Shop.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                IdentityHelper.SignIn(manager, user, isPersistent: false);
				CreateApplicationProfile(user);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else 
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }

		/// <summary>
		/// creates application profile which is being used throughout user session
		/// </summary>
	    private void CreateApplicationProfile( ApplicationUser notConfirmedUser)
	    {
		    //var authenticatedUser = Context.GetOwinContext().Authentication.User;

		    if ( notConfirmedUser != null  )
		    {
			    using (var uom = new UnitOfWork())
			    {
				    var userProfile = new UserProfile();

					userProfile.Id				= notConfirmedUser.Id;
				    userProfile.profile_id		= notConfirmedUser.Id;
					userProfile.email			= notConfirmedUser.Email;
					
					userProfile.type			= ProfileEnum.Person;
					userProfile.first_name		= string.Empty;
					userProfile.last_name		= string.Empty;
					userProfile.shop_name		= string.Empty;
					userProfile.address_one		= string.Empty;
					userProfile.City			= uom.CityRepository.GetByID(1);
					userProfile.adress_two		= string.Empty;
					userProfile.phone_one		= string.Empty;
					userProfile.phone_two		= string.Empty;
					userProfile.terms_accespted = false;

				    uom.UserRepository.Insert(userProfile);
				    uom.Save();
			    }
		    }
	    }
    }
}