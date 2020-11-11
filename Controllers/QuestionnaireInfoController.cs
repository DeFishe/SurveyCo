using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyCo.Data;
using SurveyCo.Models;

namespace SurveyCo.Controllers
{
    public class QuestionnaireInfoController : Controller
    {
        private readonly SurveyCoDbContext _context;

        public QuestionnaireInfoController(SurveyCoDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateQuestionnaireViewModel cqvm)
        {
            
            //This is AWFUL. Fix this later.
            Questionnaire questionnaire = new Questionnaire();
            questionnaire.CompanyID = cqvm.CompanyID;  
            _context.Add(questionnaire);
            _context.SaveChanges();

            var questionnaires = from m in _context.Questionnaires
                          select m;
            int newestQuestID = 0;
            foreach (var item in questionnaires)
            {
                if (item.QuestionnaireID > newestQuestID)
                {
                    newestQuestID = item.QuestionnaireID;
                }
            }

            foreach (var question in cqvm.Questions)
            {
                question.QuestionnaireID = newestQuestID;
            }

            _context.AddRange(cqvm.Questions);
            _context.SaveChanges();

            return RedirectToAction(nameof(Result));
        }

        public IActionResult Result()
        {
            return View();
        }

        
    }
}