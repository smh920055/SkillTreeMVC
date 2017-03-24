using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_HomeWork.Models
{
    public enum CategoryType
    {
        收入,
        支出
    }
    public class CategoryClass
    {
        public CategoryType Category { get; set; }
    }
}