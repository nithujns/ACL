using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALC_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
        

        public ActionResult HowItWorks()
        {

            return View();
        }

        public ActionResult AvailableReliefOptions()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contactus()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Scheduleacallback()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TestPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HomePage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult _Header()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult _Footer()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public Boolean ajaxContact()
        {
            Models.Contact obj = new Models.Contact();
            obj.contactName = Request.Form["contactName"];
            obj.contactPhone = Request.Form["contactPhone"];
            obj.contactEmail = Request.Form["contactEmail"];
            obj.contactBestDatetoCall = Request.Form["contactBestDatetoCall"];
            obj.contactBestTimetoCall = Request.Form["contactBestTimetoCall"];
            obj.contactApprovalCode = Request.Form["contactApprovalCode"];
            obj.contactMessage = Request.Form["contactMessage"];

            Models.SaveUpdate saveObj = new Models.SaveUpdate();
            saveObj.saveContact(obj);

            return true;
        }

       
    }
}