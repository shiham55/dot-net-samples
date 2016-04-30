using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace DotNetSamples.WebForms
{
	public class BundleConfig
	{
		// For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkID=303951
		public static void RegisterBundles(BundleCollection bundles)
		{
			//define script bundles and corresponding files
			bundles.Add(new ScriptBundle("~/scripts/allJs").Include(
							"~/common/shoptheme/js/*.js"));

			//define style bundles and corresponding files
			//bundles.Add(new StyleBundle("~/styles/allCss").Include(new string[]{
			//				"~/common/shoptheme/css/*.css" }));

			bundles.Add(new StyleBundle("~/styles/allCss").Include(new string[]{
							"~/common/shoptheme/css/bootstrap.css",
							"~/common/shoptheme/css/shop-homepage.css",
							"~/common/shoptheme/css/theme.css"
							 }));

			BundleTable.EnableOptimizations = false;

			#region Commented Code
			//bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
			//				"~/Scripts/WebForms/WebForms.js",
			//				"~/Scripts/WebForms/WebUIValidation.js",
			//				"~/Scripts/WebForms/MenuStandards.js",
			//				"~/Scripts/WebForms/Focus.js",
			//				"~/Scripts/WebForms/GridView.js",
			//				"~/Scripts/WebForms/DetailsView.js",
			//				"~/Scripts/WebForms/TreeView.js",
			//				"~/Scripts/WebForms/WebParts.js"));

			//// Order is very important for these files to work, they have explicit dependencies
			//bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
			//		"~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
			//		"~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
			//		"~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
			//		"~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

			//// Use the Development version of Modernizr to develop with and learn from. Then, when you’re
			//// ready for production, use the build tool at http://modernizr.com to pick only the tests you need
			//bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
			//				"~/Scripts/modernizr-*"));

			//// Set EnableOptimizations to false for debugging. For more information,
			//// visit http://go.microsoft.com/fwlink/?LinkId=301862
			//BundleTable.EnableOptimizations = true;

			//ScriptManager.ScriptResourceMapping.AddDefinition(
			//	"respond",
			//	new ScriptResourceDefinition
			//	{
			//		Path = "~/Scripts/respond.min.js",
			//		DebugPath = "~/Scripts/respond.js",
			//	});
			#endregion
		}
	}
}