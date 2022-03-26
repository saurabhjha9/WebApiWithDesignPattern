using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SQL.DataModel
{
    public class UserRoles
    {
        public double UserRoleID { get; set; }
        public string UserRoleDesc { get; set; }
        public bool IsActive { get; set; }
    }
}
