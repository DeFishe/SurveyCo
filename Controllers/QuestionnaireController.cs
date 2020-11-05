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
            return View();
        }
    }
}