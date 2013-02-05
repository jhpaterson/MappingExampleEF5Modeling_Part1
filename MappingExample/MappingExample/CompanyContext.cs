using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace MappingExample
{
    public class CompanyContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<SalariedEmployee> SalariedEmployees { get; set; }
        //public DbSet<HourlyPaidEmployee> HourlyPaidEmployees { get; set; }

        public CompanyContext()
            : base()
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region TABLE SPLITTING
            //// Map both entities to same table
            //modelBuilder.Entity<Address>()
            //    .ToTable("Addresses");

            //modelBuilder.Entity<PostCode>()
            //    .ToTable("Addresses");

            //// need to have one-to-one relationship configured with navigation properties and 
            //// configuration of which entity is principal or dependent
            //modelBuilder.Entity<PostCode>()
            //    .HasRequired(p => p.Address)
            //    .WithRequiredDependent(a => a.PostCode);
            #endregion

            #region ENTITY SPLITTING
            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.Photo)
            //    .HasColumnType("image");

            //modelBuilder.Entity<Employee>()
            //   .Map(e =>
            //   {
            //       e.Properties(x => new { x.EmployeeId, x.Name, x.Username, x.PhoneNumber });
            //       e.ToTable("Employees");
            //   });

            //modelBuilder.Entity<Employee>()
            //  .Map(e =>
            //  {
            //      e.Properties(x => new { x.Biography, x.Photo });
            //      e.ToTable("EmployeeDetails");
            //  });
            #endregion

            #region TPH
            modelBuilder.Entity<Employee>()
                 .Map<HourlyPaidEmployee>(h =>
                 {
                     h.Requires("EmployeeType")
                         .HasValue("HO");
                 })
                 .Map<SalariedEmployee>(s =>
                 {
                     s.Requires("EmployeeType")
                         .HasValue("SA");
                 }); 
            #endregion

            #region TPT
            //modelBuilder.Entity<Employee>()
            //     .Map<HourlyPaidEmployee>(m =>
            //     {
            //         m.ToTable("HourlyPaidEmployees");
            //     })
            //     .Map<SalariedEmployee>(m =>
            //     {
            //         m.ToTable("SalariedEmployees");
            //     });
            #endregion

            #region TPC
            //modelBuilder.Entity<Employee>()
            //    .Map<HourlyPaidEmployee>(m =>
            //     {
            //         m.ToTable("HourlyPaidEmployees");
            //         m.MapInheritedProperties();
            //     })
            //     .Map<SalariedEmployee>(m =>
            //     {
            //         m.ToTable("SalariedEmployees");
            //         m.MapInheritedProperties();
            //     });
            #endregion

        }
    }
}
