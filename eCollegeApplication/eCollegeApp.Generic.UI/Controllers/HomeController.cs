using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCollegeApp.Generic.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        public new ActionResult Profile()
        {
            return View("Profile");
        }

        public ActionResult Contact()
        {
            return View("Contact");
        }
    }
}