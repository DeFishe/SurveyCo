using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyCo.Models
{
    public class Questionnaire
    {
        public int QuestionnaireID { get; set; }
        public int CompanyID { get; set; }
        public Company Company { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
