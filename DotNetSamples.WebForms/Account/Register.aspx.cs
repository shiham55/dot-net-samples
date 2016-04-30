using System.Collections.ObjectModel;
using System.Net.Mail;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using System;
using System.Linq;
using System.Web;
using DotNetSamples.Entities;
using Page = System.Web.UI.Page;
using DotNetSamples.WebForms.Models;

namespace DotNetSamples.WebForms.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var					manager			= Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
			var					user			= new ApplicationUser() { UserName = Email.Text, Email = Email.Text};
            IdentityResult		result			= manager.Create(user, Password.Text);

            if (result.Succeeded)
            {
                IdentityHelper.SignIn(manager, user, isPersistent: false);
				
				//send confirmation email
				var				code			= manager.GenerateEmailConfirmationToken<ApplicationUser,int>(user.Id);
				string			callbackUrl		= IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id.ToString());
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");
	            using ( var mailClient = new SmtpClient("localhost", 25) )
	            {
		           MailMessage	message			= new MailMessage("local@test", "shiham55@gmail.com", "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

					mailClient.Send(message);
	            }

                // PLEASE NOTE: This is an insecure way of confirming a user. This is for demo purpose only
                // The ideally approach is to send an email link to the user and confirm it. 
                // THIS FLOW IS FOR DEMO PURPOSES ONLY
				//var				code			= manager.GenerateEmailConfirmationToken<ApplicationUser,int>(user.Id);
				//Response.Redirect(IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id.ToString()));

                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else 
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}