using System;
using System.Collections.Generic;

namespace DotNetSamples.Entities
{
	public partial class City
	{
		public City()
		{
			
		}

		public int ID { get; set; }
		public string url_key { get; set; }
		//public int district_id { get; set; }

		public virtual District District { get; set; }
	} 
}