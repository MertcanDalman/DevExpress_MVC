using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaseStudy_Data.Concrete.Config;
using CaseStudy_Entity.Concrete;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using Microsoft.EntityFrameworkCore;

public class CaseStudyContext : DbContext
{
    public CaseStudyContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Document> Documents { get; set; }
    public DbSet<CaseStudy_Entity.Concrete.License> Licenses { get; set; }
  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DocumentConfig).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
}

