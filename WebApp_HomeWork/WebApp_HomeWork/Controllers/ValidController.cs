using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_HomeWork.Controllers
{
    public class ValidController : Controller
    {
        // GET: Valid
        public ActionResult Index(DateTime date)
        {
            bool isValidate = DateTime.Today >= Convert.ToDateTime(date.ToShortDateString());
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}