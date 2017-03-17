using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp_HomeWork.Models
{
    public class MoneyClass
    {
        [DisplayName("類別")]
        public string category { get; set; }

        [DisplayName("金額")]
        public decimal money { get; set; }

        [DisplayName("日期")]
        public DateTime date { get; set; }

        [DisplayName("備註")]
        public string description { get; set; }
    }
}