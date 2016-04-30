using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Services.ServiceClient client = new Services.ServiceClient("BasicHttpBinding_IService");

			try 
			{	        
				client.Open();

				var testData = client.GetAllDistricts();

				var taetDataTwo = client.GetCitiesByDistrictId( testData.First().ID );
			}
			catch (Exception ex)
			{
				Console.WriteLine ( ex.Message );
			}
			client.Close();
		}
	}
}
