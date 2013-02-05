using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Transactions;
using System.Xml;      // need to add assembly reference
//using LinqKit;


namespace MappingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // set database initializer
            Database.SetInitializer<CompanyContext>(new CompanyContextInitializer());

            // initialise EF Profiler
            //HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();

            CompanyContext db = new CompanyContext();

            #region COMPLEX TYPE
            var query = db.Employees       // don't need to Include Address as it is stored in same table and loaded with entity
                .ToList();
            #endregion

            #region ENTITY
            //var query = db.Employees       // need to Include Address as it is stored in separate table
            //    //.Include(e => e.Address)
            //    .ToList();
            #endregion

            #region TABLE SPLITTING
            //var query = db.Employees
            //    .Include(e => e.Address)
            //    //.Include(e => e.Address.PostCode)      // need to Include Address.PostCode as postcode is not loaded even though it is in same table
            //    .ToList();
            #endregion

            #region ENTITY SPLITTING
            //var query = db.Employees
            //    .Include(e => e.Address)
            //    .ToList();
            #endregion

            #region INHERITANCE
            //var query = db.Employees
            //    //var query = db.SalariedEmployees
            //    //.OfType<SalariedEmployee>()
            //    .Include(e => e.Address)
            //    .ToList();
            #endregion

            #region END
            // view DDL Script
            string script = ((IObjectContextAdapter)db).ObjectContext.CreateDatabaseScript();
            
            // Get EDMX
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(@"Model.edmx", settings))
            {
                EdmxWriter.WriteEdmx(db, writer);
            }  
             
            Console.ReadLine();
            #endregion

        }
    }
}
