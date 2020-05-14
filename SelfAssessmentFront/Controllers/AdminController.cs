using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public List<CustomersViewModel> Customerss()
        {
            List<CustomersViewModel> customers = new List<CustomersViewModel> {
                new CustomersViewModel { Id = 1, Name = "Ale" },
                new CustomersViewModel { Id = 2, Name = "Juan" },
            };
            return customers;
        }
    }
}