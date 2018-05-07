using eCollegeApp.Generic.DataCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCollegeApp.Generic.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

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