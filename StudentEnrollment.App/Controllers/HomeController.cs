using StudentEnrollment.App.Filters;
using StudentEnrollment.App.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentEnrollment.App.Controllers
{
    [RoutePrefix("Home")]
    [CrawlerFilter]
    [HandleError(ExceptionType =typeof(NullReferenceException), View ="CustomError")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new NullReferenceException();
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "This ia About page message";

            return View();
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "This is Contact page message";

            return View();
        }


        public ActionResult TestAssign()
        {
            TempData.Add("TestActionValue", "This is Redirected from Test Assign Temp Data!");
            ViewData.Add("ViewTestValue", " This is redirected from Test Assign View Data");
            return RedirectToAction(nameof(About));
        }


        [Route("Greet/{message:simple}")]
        public ActionResult Greeting(string message)
        {
            var greetMessage = new GreetMessage()
            {
                Message = message,
                Name = "ASP.NET"
            };
            var student = new Student()
            {
                Name = "Tony Stark",
                Email = "Tony@starkIndustries"
            };

            ViewData.Add("Student", student);

            ViewBag.Message = message;
            ViewBag.Student = student;

            TempData.Add("Student", student);
            return View("~/Views/Home/Greeting.cshtml", greetMessage);
        }

        override on
    }
}