using StudentsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsMVC.Controllers
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
            ViewBag.Message = "Contact Page  - Academy of Learning";

            return View();
        }
        public ActionResult Instructor(int id  = 0) // Set a default value to avoid  error when  no id is specified in URL
        {
            ViewBag.Id = id;



            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Norman",
                LastName = "Teodoro"
            };

            return View(dayTimeInstructor);
        }
        public ActionResult Instructors() 
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Norman",
                    LastName = "Teodoro"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Sheryl",
                    LastName = "Teodoro"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Olivia",
                    LastName = "Teodoro"
                },

            };
            return View(instructors);
        }
    }
}