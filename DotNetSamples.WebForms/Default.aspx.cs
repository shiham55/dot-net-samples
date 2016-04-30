using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DotNetSamples.Entities;
using DotNetSample.WebForms.BaseClasses;
using System.ServiceModel;
using System.Text;


namespace DotNetSamples.WebForms
{
	public partial class Default : BasePage
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			Services.ServiceClient client = new Services.ServiceClient("BasicHttpBinding_IService");

			try 
			{	        
				client.Open();

				var testData = client.GetAllDistricts();

				StringBuilder sb= new StringBuilder();

				foreach (Services.District district in testData)
				{
					sb.AppendLine( district.name );
					sb.AppendLine( Environment.NewLine + "<br/>");
				}

				lblError.Text = sb.ToString();

				//var taetDataTwo = client.GetCitiesByDistrictId( testData.First().ID );
			}
			catch (Exception ex)
			{
				lblError.Text = ex.Message;
			}
			client.Close();
		}
	}
}