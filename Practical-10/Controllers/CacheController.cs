using System;
using System.Web.Mvc;

namespace Practical_10.Controllers
{
    public class CacheController : Controller
    {
        [OutputCache(Duration = 300)]
        public ActionResult GetTime()
        {
            string currTime = DateTime.Now.ToString();
            ViewBag.Time = currTime;
            return View();
        }
    }
}