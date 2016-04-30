using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DotNetSamples.Entities;
using DotNetSamples.Data;

namespace DotNetSamples.WCF
{
	[ServiceContract]
	public interface IService 
	{
		//[OperationContract]
		//List<District> GetAllDistricts();

		//[OperationContract]
		//List<City> GetCitiesByDistrictId( int districtId );

		//[OperationContract]
		//CompositeType GetDataUsingDataContract(CompositeType composite);

		// TODO: Add your service operations here
	}


	//[ServiceContract]
	//public interface IDotNetSampleService
	//{
	//	//[OperationContract]
	//	//List<Account>	GetFacebookAccounts();

	//	//[OperationContract]
	//	//string GetResults();

	//	[OperationContract]
	//	List<object> GetObjectList();

	//	[OperationContract]
	//	string GetTestString();

	//	[OperationContract]
	//	IEnumerable<TestEntity> GetAllCategories();
	//}
}
