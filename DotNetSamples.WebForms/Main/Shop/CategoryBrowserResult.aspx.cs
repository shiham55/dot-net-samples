using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.DotNetSamples.WebForms.Main.Shop
{
	public partial class CategoryBrowserResult : System.Web.UI.Page
	{
		#region Properties
		public string PrimaryCategory
		{
			get
			{
				if ( RouteData.Values["primaryCategory"] != null )
				{
					 return RouteData.Values["primaryCategory"].ToString();	
				}
				return string.Empty;
			}
		}

		public string SecondaryCategory
		{
			get
			{
				if ( RouteData.Values["secondaryCategory"] != null )
				{
					return RouteData.Values["secondaryCategory"].ToString();
				} 
				return string.Empty;
			}
		}
		#endregion

		protected void Page_Load(object sender, EventArgs e)
		{
			
		}
	}
}