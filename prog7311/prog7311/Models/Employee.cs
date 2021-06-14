using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prog7311.Models
{
    public partial class Employee
    {
        public Item ItemID { get; set; }

        public int  quantity { get; set; }

        public Item category { get; set; }



        public DateTime time { get; set; }

    }
}