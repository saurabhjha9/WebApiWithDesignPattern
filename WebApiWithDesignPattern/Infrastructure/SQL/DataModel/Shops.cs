using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SQL.DataModel
{
    public class Shops
    {
        public double ShopID { get; set; }
        public string ShopName { get; set; }
        public string Password { get; set; }
        public string GSTNO { get; set; }
        public string AddressFirstLine { get; set; }
        public string AddressLastLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public bool ShopStatusID { get; set; }
        public double ShopTypeID { get; set; }
        public double OrganisationID { get; set; }
        public double CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
