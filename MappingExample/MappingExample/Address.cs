using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MappingExample
{
    public class Address
    {
        #region COMPLEX TYPE
        public int PropertyNumber { get; set; }
        public string Area { get; set; }
        public string Property { get; set; }

        [NotMapped]
        public string PostCode
        {
            get { return String.Format("{0} {1}", Area, Property); }
        }
        #endregion

        #region ENTITY
        //public int AddressId { get; set; }
        //public int PropertyNumber { get; set; }
        //public string Area { get; set; }
        //public string Property { get; set; }

        //[NotMapped]
        //public string PostCode
        //{
        //    get { return String.Format("{0} {1}", Area, Property); }
        //}
        #endregion

        #region TABLE SPLITTING
        //public int AddressId { get; set; }
        //public int PropertyNumber { get; set; }
        //public PostCode PostCode { get; set; }
        #endregion
    }
}
