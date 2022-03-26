using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SQL.DataModel
{
    public class Customers
    {
        public double CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string mobile { get; set; }
        public string AddressFirstLine { get; set; }
        public string AddressLastLine { get; set; }
        public double StateID { get; set; }
        public double CountryID { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
