using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthorSampleWebPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SampleParagraph()
        {
            return View();
        }
        public ActionResult Thesis()
        {
            return View();
        }
        public ActionResult MlaVsApa()
        {
            return View();
        }
        public ActionResult WritingProcess()
        {
            return View();
        }
        public ActionResult BodyParagraph()
        {
            return View();
        }
        public ActionResult Assignment()
        {
            return View();
        }
        public ActionResult Conclusion()
        {
            return View();
        }
    }
}