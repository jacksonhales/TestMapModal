using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMapModal.Models;

namespace TestMapModal.Controllers
{
    public class HomeController : Controller
    {

        Section section = new Section();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult partialviewme()
        {
            section.Name = "John";

            return PartialView(section);
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
    }
}