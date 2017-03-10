using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_HomeWork.Models
{
    public class MoneyClass
    {
        public string category { get; set; }

        public decimal money { get; set; }

        public DateTime date { get; set; }

        public string description { get; set; }
    }
}