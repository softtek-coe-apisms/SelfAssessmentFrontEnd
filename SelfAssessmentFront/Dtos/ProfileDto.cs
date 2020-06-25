using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAssessmentFront.Dtos
{
    public class ProfileDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Skills { get; set; }
    }
}
