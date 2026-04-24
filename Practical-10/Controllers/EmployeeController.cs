using System.Web.Mvc;

namespace Practical_10.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Route("Employee/{name?}")]
        public ActionResult Index(string name)
        {
            ViewBag.EmployeeName = name;
            return View();
        }
    }
}