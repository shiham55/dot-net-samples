using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetSamples.Entities;

namespace DotNetSamples.Data.Repository
{
    public class QuotesRepository : GenericRepository<Quotes>
    {
        public QuotesRepository(DotNetSamplesEntities dbContext) : base(dbContext)
        { }

        public Quotes GetActiveRandomQuote()
        {
            return this.Get().Where(q => q.ShowInHome == true).OrderBy(x => Guid.NewGuid()).Take(1).First();
        }
    }
}

