using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;
using System;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public ActionResult Index(string timestamp)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            return View(CreateTimecolor(unixTimestamp));
        }

        public Timecolor CreateTimecolor(int timestamp)
        {
            Timecolor timecolor = new Timecolor()
                {
                    Timestamp = timestamp
                };
            return timecolor;
        }
    }
}