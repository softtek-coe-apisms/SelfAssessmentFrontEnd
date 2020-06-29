using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelfAssessmentFront.Dtos;
using SelfAssessmentFront.ViewModels;

namespace SelfAssessmentFront.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }

        public IActionResult CustomerForm(int id)
        {
            ViewData["id"] = id;
            var customerName = "Microsoft";
            return View("CustomerForm", customerName);
        }

        public IActionResult SaveCustomer()
        {
            return Created("", "");
        }
    }
}