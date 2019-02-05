using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Event.Models;


namespace Event.Controllers
{
    public class HomeController : Controller
    {
        private DbModel db = new DbModel();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyEvents()
        {
            ViewBag.Message = "Events";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Events()
        {
            
            

        var myEvents = db.MyEvents.ToList();
            //retrieving the entire list from the Events database
            return View(myEvents);
        }

        public ActionResult ViewEvent(string EventName)
        {
            ViewBag.EventName = EventName;
            return View();
        }
    }
}