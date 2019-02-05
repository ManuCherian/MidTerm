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
            /*
            var events = new List<string>();
            
            for (int i = 1; i <=10; i++)
            {
                events.Add("Event" + i.ToString());
            }
            ViewBag.Events = events;
            */
            var myEvents = new List<MyEvent>();
            for (int i = 1; i <= 10; i++)
            {
                MyEvent events = new MyEvent();
                events.Name = "Event" + i.ToString();
                myEvents.Add(events);


            }
            
            return View(myEvents);
        }

        public ActionResult ViewEvent(string EventName)
        {
            ViewBag.EventName = EventName;
            return View();
        }
    }
}