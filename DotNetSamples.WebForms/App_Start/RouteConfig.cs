using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace DotNetSamples.WebForms
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //settings
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

			#region blog routes
			//routes.MapPageRoute("admin-home", "login", "~/Admin/BlogPosts/Default.aspx");
			//routes.MapPageRoute("about-page", "About", "~/Main/About.aspx");
			#endregion

			//routes.MapPageRoute( "shop-home", "", "~/Shop/Home.aspx" );
			routes.MapPageRoute( "shop-user-login", "login", "~/Account/Login.aspx" );
			routes.MapPageRoute( "shop-register", "register", "~/Account/Register.aspx");

			routes.MapPageRoute( "primary-category", "{primaryCategory}", "~/Main/Shop/CategoryBrowserResult.aspx");
			routes.MapPageRoute( "secondary-category", "{primaryCategory}/{secondaryCategory}", "~/Main/Shop/CategoryBrowserResult.aspx");
        }
    }
}
