using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace MappingExample
{
    public class CompanyContextInitializer : DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            base.Seed(context);

            #region COMPLEX TYPE and ENTITY
            Address ad1 = new Address
            {
                PropertyNumber = 10,
                Area = "G10",
                Property = "1XX"
            };

            Address ad2 = new Address
            {
                PropertyNumber = 20,
                Area = "G20",
                Property = "1YY"
            };

            // Create Address objects
            Address ad3 = new Address
            {
                PropertyNumber = 30,
                Area = "G30",
                Property = "1ZZ"
            };

            HourlyPaidEmployee emp1 = new HourlyPaidEmployee
            {
                Name = "Jenson",
                Username = "jenson",
                PhoneNumber = "9876",
                Address = ad1
            };

            SalariedEmployee emp2 = new SalariedEmployee
            {
                Name = "Checo",
                Username = "checo",
                PhoneNumber = "5432",
                Address = ad1,
                PayGrade = 1
            };

            HourlyPaidEmployee emp3 = new HourlyPaidEmployee
            {
                Name = "Fernando",
                Username = "fernando",
                PhoneNumber = "1234",
                Address = ad2,
            };

            SalariedEmployee emp4 = new SalariedEmployee
            {
                Name = "Felipe",
                Username = "felipe",
                PhoneNumber = "5678",
                Address = ad2,
                PayGrade = 5
            };

            SalariedEmployee emp5 = new SalariedEmployee
            {
                Name = "Seb",
                Username = "seb",
                PhoneNumber = "1468",
                Address = ad3,
                PayGrade = 9
            };

            context.Employees.Add(emp1);
            context.Employees.Add(emp2);
            context.Employees.Add(emp3);
            context.Employees.Add(emp4);
            context.Employees.Add(emp5);
            #endregion


            #region TABLE SPLITTING and ENTITY SPLITTING
            //Configure Address/PostCode and context for TABLE SPLITTING
            //Address ad1 = new Address
            //{
            //    PropertyNumber = 10,
            //    PostCode = new PostCode
            //    {
            //        Area = "G10",
            //        Property = "1XX"
            //    }
            //};

            //Address ad2 = new Address
            //{
            //    PropertyNumber = 20,
            //    PostCode = new PostCode
            //    {
            //        Area = "G20",
            //        Property = "1YY"
            //    }
            //};

            //// Create Address objects
            //Address ad3 = new Address
            //{
            //    PropertyNumber = 30,
            //    PostCode = new PostCode
            //    {
            //        Area = "G30",
            //        Property = "1ZZ"
            //    }
            //};

            //HourlyPaidEmployee emp1 = new HourlyPaidEmployee
            //{
            //    Name = "Jenson",
            //    Username = "jenson",
            //    PhoneNumber = "9876",
            //    Biography = "Jenson is a good bloke who has done a lot of stuff",
            //    Photo = new byte[100],
            //    Address = ad1
            //};

            //SalariedEmployee emp2 = new SalariedEmployee
            //{
            //    Name = "Checo",
            //    Username = "checo",
            //    PhoneNumber = "5432",
            //    Biography = "Checo is a new guy who has very good qualifications",
            //    Photo = new byte[100],
            //    Address = ad1,
            //    PayGrade = 1
            //};

            //HourlyPaidEmployee emp3 = new HourlyPaidEmployee
            //{
            //    Name = "Fernando",
            //    Username = "fernando",
            //    PhoneNumber = "1234",
            //    Biography = "Fernando is very highly regarded in the industry",
            //    Photo = new byte[100],
            //    Address = ad2,
            //};

            //SalariedEmployee emp4 = new SalariedEmployee
            //{
            //    Name = "Felipe",
            //    Username = "felipe",
            //    PhoneNumber = "5678",
            //    Biography = "Felipe has been with the compnay for a very long time",
            //    Photo = new byte[100],
            //    Address = ad2,
            //    PayGrade = 5
            //};

            //SalariedEmployee emp5 = new SalariedEmployee
            //{
            //    Name = "Seb",
            //    Username = "seb",
            //    PhoneNumber = "1468",
            //    Biography = "Seb is a jolly nice chap",
            //    Photo = new byte[100],
            //    Address = ad3,
            //    PayGrade = 9
            //};

            //context.Employees.Add(emp1);
            //context.Employees.Add(emp2);
            //context.Employees.Add(emp3);
            //context.Employees.Add(emp4);
            //context.Employees.Add(emp5);
            #endregion


            #region TPC
            // Configure Address/PostCode and context for TABLE SPLITTING
            //Address ad1 = new Address
            //{
            //    PropertyNumber = 10,
            //    PostCode = new PostCode
            //    {
            //        Area = "G10",
            //        Property = "1XX"
            //    }
            //};

            //Address ad2 = new Address
            //{
            //    PropertyNumber = 20,
            //    PostCode = new PostCode
            //    {
            //        Area = "G20",
            //        Property = "1YY"
            //    }
            //};

            //// Create Address objects
            //Address ad3 = new Address
            //{
            //    PropertyNumber = 30,
            //    PostCode = new PostCode
            //    {
            //        Area = "G30",
            //        Property = "1ZZ"
            //    }
            //};

            //HourlyPaidEmployee emp1 = new HourlyPaidEmployee
            //{
            //    EmployeeId = 1,
            //    Name = "Jenson",
            //    Username = "jenson",
            //    PhoneNumber = "9876",
            //    Biography = "Jenson is a good bloke who has done a lot of stuff",
            //    Photo = new byte[100],
            //    Address = ad1
            //};

            //SalariedEmployee emp2 = new SalariedEmployee
            //{
            //    EmployeeId = 2,
            //    Name = "Checo",
            //    Username = "checo",
            //    PhoneNumber = "5432",
            //    Biography = "Checo is a new guy who has very good qualifications",
            //    Photo = new byte[100],
            //    Address = ad1,
            //    PayGrade = 1
            //};

            //HourlyPaidEmployee emp3 = new HourlyPaidEmployee
            //{
            //    EmployeeId = 3,
            //    Name = "Fernando",
            //    Username = "fernando",
            //    PhoneNumber = "1234",
            //    Biography = "Fernando is very highly regarded in the industry",
            //    Photo = new byte[100],
            //    Address = ad2,
            //};

            //SalariedEmployee emp4 = new SalariedEmployee
            //{
            //    EmployeeId = 4,
            //    Name = "Felipe",
            //    Username = "felipe",
            //    PhoneNumber = "5678",
            //    Biography = "Felipe has been with the compnay for a very long time",
            //    Photo = new byte[100],
            //    Address = ad2,
            //    PayGrade = 5
            //};

            //SalariedEmployee emp5 = new SalariedEmployee
            //{
            //    EmployeeId = 5,
            //    Name = "Seb",
            //    Username = "seb",
            //    PhoneNumber = "1468",
            //    Biography = "Seb is a jolly nice chap",
            //    Photo = new byte[100],
            //    Address = ad3,
            //    PayGrade = 9
            //};

            //context.Employees.Add(emp1);
            //context.Employees.Add(emp2);
            //context.Employees.Add(emp3);
            //context.Employees.Add(emp4);
            //context.Employees.Add(emp5);
            #endregion

            context.SaveChanges();

        }
    }
}
