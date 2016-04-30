using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;

namespace DotNetSample.WebForms.BaseClasses
{
	public class BasePage : Page
	{
		private int _page = 0;

		public int PageId
		{
			get { return _page; }
			set { this._page = value; }
		}
	}
}