using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

using System;
using System.Web;
using System.Web.UI;
using Owin;
using DotNetSamples.Entities;
using DotNetSamples.WebForms.Models;

namespace DotNetSamples.WebForms.Account
{
    public partial class ResetPassword : Page
    {
        protected string StatusMessage
        {
            get;
            private set;
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            string code = IdentityHelper.GetCodeFromRequest(Request);
            if (code != null)
            {
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();

                var user = manager.FindByName(Email.Text);
                if (user == null)
                {
                    ErrorMessage.Text = "An user found";
                    return;
                }
                var result = manager.ResetPassword(user.Id, code, Password.Text);
                if (result.Succeeded)
                {
                    Response.Redirect("~/Account/ResetPasswordConfirmation");
                    return;
                }
            }

            ErrorMessage.Text = "An error has occurred";
        }
    }
}