
using System;
using System.Text;
using System.EnterpriseServices;
using System.Web.Mvc;

namespace Assisted1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public ActionResult Info(String t)
        {
            ViewData["Message"] = "You have requested info for " + t;

            return View();
        }
        [HttpPost]
        public ActionResult StudentDetails(String t)
        {
            StringBuilder sb = new StringBuilder("<b>Student details entered:</b><br>");
            sb.Append("Name: " + Request.Form["name"].ToString() + "<Br>");
            sb.Append("Address: " + Request.Form["address"].ToString() + "<Br>");
            sb.Append("Subject: " + Request.Form["subject"].ToString() + "<Br>");

            ViewData["message"] = sb.ToString();
            return View();
        }

    }
}

