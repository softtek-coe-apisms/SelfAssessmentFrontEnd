using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SelfAssessmentFront.Controllers
{
    public class SkillCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SkillCategoryList()
        {
            return View();
        }
    }
}