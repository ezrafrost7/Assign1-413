using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assign1_413.Models
{
    public class CalculatorModel
    {
        //declaring the parts of the model
        //above each attribute is a requirement
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public double assignments { get; set; }
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public double groupProjects { get; set; }
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public double quizzes { get; set; }
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public double exams { get; set; }
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public double intex { get; set; }
    }
}
