using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SQL.DataModel
{
    public class Products
    {
        public double ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public double ProductStatusID { get; set; }
        public double CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
