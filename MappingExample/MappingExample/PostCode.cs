using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MappingExample
{
    public class PostCode
    {
        [Key]
        public int AddressID { get; set; }
        public string Area { get; set; }
        public string Property { get; set; }
        public Address Address { get; set; }

        [NotMapped]
        public string FullCode
        {
            get { return String.Format("{0} {1}", Area, Property); }
        }

    }
}
