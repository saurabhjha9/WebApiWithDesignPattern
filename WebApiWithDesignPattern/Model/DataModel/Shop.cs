using System;
using System.Collections.Generic;
using System.Text;

namespace Model.DataModel
{
    public class Shop
    {
        public double ShopID { get; set; }
        public string ShopName { get; set; }
        public string Password { get; set; }
        public string GSTID { get; set; }
        public string AddressFirstLine { get; set; }
        public string AddressLastLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public bool ShopStatusID { get; set; }
        public double ShopTypeID { get; set; }
        public double CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
