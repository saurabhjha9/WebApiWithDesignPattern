using System;
using System.Collections.Generic;
using System.Text;

namespace Model.DataModel
{
    public class UserStatusLK
    {
        public double INACTIVE { get; set; } = 100;
        public double ACTIVE { get; set; } = 120;
        public double PENDING { get; set; } = 140;
    }
}
