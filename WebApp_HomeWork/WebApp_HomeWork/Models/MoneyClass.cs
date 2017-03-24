using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_HomeWork.Models
{
    public class MoneyClass
    {
        [Required]
        [DisplayName("類別")]
        public CategoryType category { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "請填寫金額")]
        [Range(1, Int64.MaxValue, ErrorMessage = "金額欄位僅能為正整數")]
        [DisplayName("金額")]
        public decimal money { get; set; }

        [Remote("Index", "Valid", ErrorMessage = "日期不得大於今天")]
        [Required(ErrorMessage = "請填寫日期")]
        [DisplayName("日期")]
        public DateTime date { get; set; }

        [MaxLength(100)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "請填寫備註")]
        [DisplayName("備註")]
        public string description { get; set; }
    }
}