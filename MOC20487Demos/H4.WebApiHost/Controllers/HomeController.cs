using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H4.WebApiHost2.Controllers
{
    // MVC
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
