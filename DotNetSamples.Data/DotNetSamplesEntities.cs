using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DotNetSamples.Entities;
    
public partial class DotNetSamplesEntities : DbContext
{	
    public DotNetSamplesEntities()
        : base("name=ShopDatabaseEntities")
    {
        this.Configuration.LazyLoadingEnabled = false;
    }
    
	protected override void OnModelCreating(DbModelBuilder modelBuilder)
	{
		//throw new UnintentionalCodeFirstException();
	}
    public virtual DbSet<City> Cities { get; set; }
    public virtual DbSet<District> Districts { get; set; }
}

