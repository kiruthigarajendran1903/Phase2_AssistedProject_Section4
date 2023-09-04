using System;
using System.Text;
using System.EnterpriseServices;
using System.Web.Mvc;

namespace Phase3Section2._3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return (IActionResult)View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return (IActionResult)View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return (IActionResult)View();
        }

        public IActionResult Error()
        {
            return (IActionResult)View();
        }

        public IActionResult Info(String t)
        {
            ViewData["Message"] = "You have requested info for " + t;

            return (IActionResult)View();
        }
        [HttpPost]
        public IActionResult StudentDetails(String t)
        {
            StringBuilder sb = new StringBuilder("<b>Student details entered:</b><br>");
            sb.Append("Name: " + Request.Form["name"].ToString() + "<Br>");
            sb.Append("Address: " + Request.Form["address"].ToString() + "<Br>");
            sb.Append("Subject: " + Request.Form["subject"].ToString() + "<Br>");

            ViewData["message"] = sb.ToString();
            return (IActionResult)View();
        }

    }
}
