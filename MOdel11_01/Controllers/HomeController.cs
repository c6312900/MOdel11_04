using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MOdel11_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home
        public ActionResult TempDataDemo()
        {
            ViewData["key1"] = DateTime.Now.ToString();
            ViewBag.Key2= DateTime.Now.ToString();
            TempData["key3"]= DateTime.Now.ToString();

            return RedirectToAction("TempDataDemo2");
        }

        public ActionResult TempDataDemo2()
        {
            return View();
        }

        public ActionResult SessionDemo()
        {
            if (Session["count"] == null)
                Session["count"] = 0;
            else
                Session["count"] = (int)Session["count"] + 1;

            return View();
        }


    }
}