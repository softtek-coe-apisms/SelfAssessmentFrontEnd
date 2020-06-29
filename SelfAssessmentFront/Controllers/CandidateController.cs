using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SelfAssessmentFront.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult SelfAssessment()
        {
            return View();
        }

        public IActionResult Progress()
        {
            var courses = new Api.CandidateController().Progress();
            ViewBag.PercentageCompleted = courses.Aggregate(0.0, (p, n) => p += n.IsCompleted ? 1 : 0, r => r * 100 / courses.Count );
            return View();
        }
    }
}