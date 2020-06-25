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

        public List<CustomersViewModel> Customerss()
        {
            List<CustomersViewModel> customers = new List<CustomersViewModel> {
                new CustomersViewModel { Id = 1, Name = "Ale" },
                new CustomersViewModel { Id = 2, Name = "Juan" },
            };
            return customers;
        }
        public List<ProfileDto> Profiles()
        {
            return new List<ProfileDto>
            {
                new ProfileDto{ Id = 1, Name = "Ninja developer", Skills = new List<string>{ ".net", "java"} },
                new ProfileDto{ Id = 1, Name = "React sinior", Skills = new List<string>{ "javaScript", "React"} }
            };
        }
    }
}