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

        private QuotesRepository        _quotesRepository;

        #region Properties

        public QuotesRepository QuotesRepository
        {
            get
            {
                if (_quotesRepository == null)
                {
                    _quotesRepository = new QuotesRepository(_dbContext);
                }
                return _quotesRepository;
            }
        }

		#endregion

		#region Generic Methods
		public void Save()
        {
            //<TODO> : Handle validation errors and exceptions
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
