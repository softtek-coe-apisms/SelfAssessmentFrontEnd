using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using InterviewFront.Models;
using Microsoft.AspNetCore.Mvc;
using SelfAssessmentFront.ViewModels;

namespace SelfAssessmentFront.Controllers
{
    public class InterviewerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Interview()
        {
            return View();
        }

        public IActionResult SearchCandidate()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public List<CandidatesViewModel> FoundCandidates()
        {
            return new List<CandidatesViewModel>()
            {
                new CandidatesViewModel() { Name = "Juan", Email = "juan@softtek.com" },
                new CandidatesViewModel() { Name = "José", Email = "jose@softtek.com" },
                new CandidatesViewModel() { Name = "Teresa", Email = "teresa@softtek.com" },
                new CandidatesViewModel() { Name = "Fer" , Email = "fer@softtek.com" },
            };
        }

        [HttpGet]
        public List<CandidatesViewModel> SuggestedCandidates()
        {
            return new List<CandidatesViewModel>()
            {
                new CandidatesViewModel() { Name = "Juan", Email = "juan@softtek.com" },
                new CandidatesViewModel() { Name = "José", Email = "jose@softtek.com" },
                new CandidatesViewModel() { Name = "Teresa", Email = "teresa@softtek.com" },
                new CandidatesViewModel() { Name = "Fer" , Email = "fer@softtek.com" },
            };
        }
    }
}