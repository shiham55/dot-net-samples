using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using DotNetSamples.Data.Repository;
using DotNetSamples.Entities;


namespace DotNetSamples.Data
{
	public class UnitOfWork : IDisposable
    {
		private DotNetSamplesEntities	_dbContext = new DotNetSamplesEntities();

		private CityRepository			_cityRepository;
		private DistrictRepository		_districtRepository;
		
		#region Properties
	
		public CityRepository CityRepository
		{
			get
			{
				if (_cityRepository == null )
				{
					_cityRepository		= new CityRepository(_dbContext);
				}
				return _cityRepository;
			}			
		}

		public DistrictRepository  DistrictRepository
		{
			get
			{
				if (_districtRepository == null )
				{
					_districtRepository		= new DistrictRepository(_dbContext);
				}
				return _districtRepository;
			}			
		}

		#endregion

		#region Generic Methods
		public void Save()
        {
			if ( _dbContext.GetValidationErrors().Count()  == 0 )
			{
				_dbContext.SaveChanges();
			}
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
		}
		#endregion
	}
}
