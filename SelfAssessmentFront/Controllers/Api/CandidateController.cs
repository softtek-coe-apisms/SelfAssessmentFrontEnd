using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfAssessmentFront.Dtos;

namespace SelfAssessmentFront.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        [HttpGet]
        [Route("progress")]
        public List<TrainingDto> Progress()
        {
            return new List<TrainingDto> {
                new TrainingDto{ Id = 1, Name = "Udemy .NET", IsCompleted = true },
                new TrainingDto{ Id = 2, Name = "Angular", IsCompleted = true },
                new TrainingDto{ Id = 3, Name = "JavaScript", IsCompleted = false },
                new TrainingDto{ Id = 4, Name = "SQL Server", IsCompleted = true }
            };
        }
    }
}