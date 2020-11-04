using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurveyCo.Data;

namespace SurveyCo.Controllers
{
    public class AdminController : Controller
    {
        private readonly SurveyCoDbContext _context;

        public AdminController(SurveyCoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();

            return View(users);
        }
    }
}