using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Shop.Admin
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Category",
				url: "Categories",
				defaults: new { controller = "Category", action  = "Index"}
				);

			routes.MapRoute(
				name: "SubCategory",
				url: "Category/SubCategory/{action}/{pid}",
				defaults: new { controller = "SubCategory", action  = "Index", pid = UrlParameter.Optional }
				);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);

		}
	}
}
