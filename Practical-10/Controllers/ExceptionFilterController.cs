using System;
using System.Web.Mvc;

namespace Practical_10.Controllers
{
    public class ExceptionFilterController : Controller
    {
        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideByZero")]
        public ActionResult Index()
        {
            int a = 0;
            //This will throw an exception
            int b = 10;
            int res = b / a;
            return Content($"Result: {res}");
        }
    }
}