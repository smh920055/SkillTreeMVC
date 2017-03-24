using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_HomeWork.Models;

namespace WebApp_HomeWork.Helper
{
    public static class CustomHtmlExtensions
    {
        public static string ShowCategoryColor(this HtmlHelper helper, CategoryType category)
        {
            if (category == CategoryType.收入)
                return "blue";
            else
                return "red";
        }
    }
}