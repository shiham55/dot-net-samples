using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DotNetSamples.Entities;
    
public partial class DotNetSamplesEntities : DbContext
{	
    public DotNetSamplesEntities()
        : base("name=DotNetSamplesEntities")
    {
        this.Configuration.LazyLoadingEnabled = false;
    }
    
	protected override void OnModelCreating(DbModelBuilder modelBuilder)
	{
		//throw new UnintentionalCodeFirstException();
	}

    public virtual DbSet<Quotes> Quotes { get; set; }
}

