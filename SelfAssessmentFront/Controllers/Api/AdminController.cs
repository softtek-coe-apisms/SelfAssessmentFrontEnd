using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfAssessmentFront.Dtos;
using SelfAssessmentFront.ViewModels;

namespace SelfAssessmentFront.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public List<CustomersViewModel> Customers()
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