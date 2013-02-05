using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MappingExample
{
    public abstract class Employee
    {
        protected const string EMAIL_SUFFIX = "@example.com";

        public int EmployeeId{get;set;}
        public string Name{get;set;}
        public string Username{get;set;}
        public string Biography { get; set; }
        public byte[] Photo { get; set; }
        public Address Address{get;set;}
        public string PhoneNumber{get;set;}

        [NotMapped]
        public virtual string Email
        {
            get
            {
                return Username + EMAIL_SUFFIX;
            }
        }

    }
}
