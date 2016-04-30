using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DotNetSamples.Entities
{
	[DataContract]
	public partial class District
	{
		public District()
		{
			//this.Cities = new HashSet<City>();
		}

		[DataMember]
		public int ID { get; set; }
		[DataMember]
		public string name { get; set; }
		[DataMember]
		public string url_key { get; set; }

	
		//[NonSerialized]
		//public virtual ICollection<City> Cities { get; set; }
	} 
}