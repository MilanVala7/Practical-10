using System.Text;
using System.Web.Mvc;

namespace Practical_10.Controllers
{
    public class ActionResultsDemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //ContentResult - Returns plain text
        public ContentResult GetText()
        {
            return Content("Hello, this is a plain text response!");
        }

        //JsonResult - Returns JSON data
        public JsonResult GetJsonData()
        {
            var data = new { Name = "Milan Vala", Age = 21 };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //EmptyResult - Returns nothing
        public EmptyResult DoNothing()
        {
            return new EmptyResult();
        }

        //FileContentResult - Returns a file (download)
        public FileResult DownloadFile()
        {
            byte[] fileBytes = Encoding.UTF8.GetBytes("Hello File Content");
            return File(fileBytes, "text/plain", "DemoFile.txt");
        }

        //RedirectResult - Redirects to another action
        public RedirectResult RedirectToGoogle()
        {
            return Redirect("https://www.google.com");
        }

        //RedirectToRouteResult - Redirects to another action
        public RedirectToRouteResult RedirectToGetText()
        {
            return RedirectToAction("GetText");
        }

        //JavaScriptResult - Returns JavaScript code
        public JavaScriptResult GetJavaScript()
        {
            var msg = "alert('Hello World');";
            return new JavaScriptResult() { Script = msg };
        }

        //PartialViewResult - Returns a partial view
        public PartialViewResult GetPartialView()
        {
            return PartialView("GetPartialView");
        }
    }
}