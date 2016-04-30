using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetSamples.Entities;

namespace DotNetSamples.Data.Repository
{
	public class DistrictRepository : GenericRepository<District>
	{
		public DistrictRepository( DotNetSamplesEntities dbContext ) : base(dbContext)
		{ }
	}
}
