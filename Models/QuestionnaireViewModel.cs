using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyCo.Models
{
    public class QuestionnaireViewModel
    {
        public List<Question> Questions { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
