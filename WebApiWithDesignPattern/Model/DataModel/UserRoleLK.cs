using System;
using System.Collections.Generic;
using System.Text;

namespace Model.DataModel
{
    public class UserRoleLK
    {
        public double ADMIN { get; set; } = 1;
        public double HELPDESK { get; set; } = 2;
        public double SHOPOWNER { get; set; } = 3;
        public double STOCKMANAGER { get; set; } = 4;
        public double CASHIER { get; set; } = 5;
    }
}
