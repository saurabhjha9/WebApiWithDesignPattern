using Infrastructure.SQL.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SQL.ResultSets
{
    public class Products
    {
        public double ProductID { get; set; }
        public string ProductDesc { get; set; }
        ProductSKU[] productSKUs { get; set; }

    }
}
