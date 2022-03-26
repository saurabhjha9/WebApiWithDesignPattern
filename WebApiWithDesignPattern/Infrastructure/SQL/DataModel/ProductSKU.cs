using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SQL.DataModel
{
    public class ProductSKU
    {
        public double ProductSKUID { get; set; }
        public string ProductSKUDesc { get; set; }
        public double ProductID { get; set; }
        public double Quantity { get; set; }
        public string BatchID { get; set; }
        public DateTime ExpriyDate { get; set; }
        public double ShopID { get; set; }
        public DateTime CreationDate { get; set; }
        public double CreatedBy { get; set; }
    }
}
