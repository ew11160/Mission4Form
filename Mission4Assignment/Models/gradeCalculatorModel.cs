using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Models
{
    public class gradeCalculatorModel
    {
        [Required] //// validation
        public string assignments { get; set; }
        [Required]
        public string groupProject { get; set; }
        [Required]
        public string quizzes { get; set; }
        [Required]
        public string midterm { get; set; }
        [Required]
        public string final { get; set; }
        [Required]
        public string intex { get; set; }
    }
}
