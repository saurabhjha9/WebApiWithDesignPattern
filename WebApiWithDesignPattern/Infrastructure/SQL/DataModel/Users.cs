using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SQL.DataModel
{
    public class Users
    {
        public double UserID { get;set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double UserRoleID { get; set; }
        public bool UserStatusID { get; set; }
        public double ShopID { get; set; }
        public double CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
