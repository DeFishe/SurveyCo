using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurveyCo.Data;
using SurveyCo.Models;

namespace SurveyCo.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly SurveyCoDbContext _context;

        public QuestionnaireController(SurveyCoDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //TODO Change index to place to enter questionnaire code
            var questions = from q in _context.Questions
                            where q.QuestionnaireID == 1
                            select q;

            return View(questions.ToList()); ;
        }

        public IActionResult Answer()
        {
            var questionnaireVM = new QuestionnaireViewModel();
            var questions = from q in _context.Questions
                            where q.QuestionnaireID == 1
                            select q;
            questionnaireVM.Questions = questions.ToList();
            return View(questionnaireVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Answer(QuestionnaireViewModel questionnaireViewModel)
        {
            //TODO: Change to context sensetive
            //for (int i = 0; i < questionnaireViewModel.Questions.Count; i++)
            //{
            //    questionnaireViewModel.Answers[i].QuestionID = 
            //        questionnaireViewModel.Questions[i].QuestionID;
            //}
            questionnaireViewModel.Answers[0].QuestionID = 1;
            questionnaireViewModel.Answers[1].QuestionID = 2;
            questionnaireViewModel.Answers[2].QuestionID = 3;
            questionnaireViewModel.Answers[3].QuestionID = 4;
            _context.AddRange(questionnaireViewModel.Answers);
            _context.SaveChanges();

            return RedirectToAction(nameof(Result));
        }

        public IActionResult Result()
        {
            return View();
        }
    }
}