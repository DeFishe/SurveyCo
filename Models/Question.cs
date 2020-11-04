using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SurveyCo.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        [Required]
        public string QuestionText { get; set; }
        public int QuestionnaireID { get; set; }
        public Questionnaire Questionnaire { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
