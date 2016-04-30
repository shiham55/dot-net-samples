using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DotNetSamples.Data;
using DotNetSamples.Data.Repository;
using DotNetSamples.Entities;

namespace DotNetSamples.WCF
{
	[ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
	public class Services : IService
	{
		#region IService Members

		public List<District> GetAllDistricts()
		{
			using ( var _uow = new UnitOfWork() )
			{
				return _uow.DistrictRepository.Get().ToList();
			}
		}

		public List<City> GetCitiesByDistrictId(int districtId)
		{
			using ( var _uow = new UnitOfWork() )
			{
				return _uow.CityRepository.GetWithRawSql( "select * from Cities C where C.DistrictID = @districtId",
															new SqlParameter("@districtId", districtId )  ).ToList();
			}
		}

		#endregion
	}
}
