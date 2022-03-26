using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SQL.DataModel
{
    public class TransactionLog
    {
        public double TransactionID { get; set; }
        public double TransactionTypeID { get; set; }
        public double ResponseCode { get; set; }
        public double ProductID { get; set; }
        public double ProductSKUID { get; set; }
        public long TransactionAmount { get; set; }
        public double Quantity { get; set; }
        public double CustomerID { get; set; }
        public DateTime CreationDate { get; set; }
        public double CreatedBy { get; set; }
    }
}
