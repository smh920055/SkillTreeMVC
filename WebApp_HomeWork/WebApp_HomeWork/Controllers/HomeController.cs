using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_HomeWork.Models;

namespace WebApp_HomeWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MoneyList()
        {
            List<MoneyClass> model = new List<MoneyClass>();
            model.Add(new MoneyClass
            {
                category = "支出",
                money = "6600",
                date = "2017-03-05",
                description = "旅遊"
            });
            model.Add(new MoneyClass
            {
                category = "收入",
                money = "66000",
                date = "2017-03-05",
                description = "薪資"
            });
            model.Add(new MoneyClass
            {
                category = "支出",
                money = "600",
                date = "2017-03-05",
                description = "交通"
            });
            return View(model);
        }
    }
}