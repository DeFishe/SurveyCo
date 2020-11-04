using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SurveyCo.Models
{
    public class Answer
    {
        public int AnswerID { get; set; }
        [Required]
        public string AnswerText { get; set; }
        public int QuestionID { get; set; }
        public Question Question { get; set; }
    }
}
