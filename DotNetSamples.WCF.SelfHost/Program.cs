using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using DotNetSamples.WCF;
using System.Diagnostics;

namespace DotNetSamples.WCF.SelfHost
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceHost host = new ServiceHost(typeof(Services));

			try
			{				
				host.Open();
				var wait = Console.ReadKey();
				
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			host.Close();
		}
	}
}
