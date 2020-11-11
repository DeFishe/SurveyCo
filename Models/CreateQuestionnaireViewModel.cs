using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyCo.Models
{
    public class CreateQuestionnaireViewModel
    {
        public int CompanyID { get; set; }

        public List<Question> Questions { get; set; }
    }
}
