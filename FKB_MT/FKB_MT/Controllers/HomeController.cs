using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FKB_MT.Controllers
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

        public ActionResult MachineDetails()
        {
            ViewBag.Message = "Main page with list of machine details.";

            return View();
        }

        public ActionResult Repairs()
        {
            ViewBag.Message = "Here will be page with repairs";

            return View();
        }

        public ActionResult Adjustments()
        {
            ViewBag.Message = "Here will be pagw with adjustments";

            return View();
        }

        public ActionResult Inspections()
        {
            ViewBag.Message = "Here will be page with inspections";

            return View();
        }

        public ActionResult Calibrations()
        {
            ViewBag.Message = "Here will be page with calibrations";

            return View();
        }

        public ActionResult Validations()
        {
            ViewBag.Message = "Here will be page with validations";

            return View();
        }
    }
}