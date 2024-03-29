﻿using Mejuri_Back_end.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mejuri_Back_end.Areas.Manage.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    [Area("manage")]
    public class QuestionController : Controller
    {
        private readonly AppDbContext _context;
        public QuestionController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Detail(int id)
        {
            Question question = _context.Questions.Include(x => x.AppUser).Include(x => x.Product).FirstOrDefault(x => x.Id == id);

            return View(question);
        }

        
        public IActionResult DeleteFetch(int id)
        {
            Question question = _context.Questions.FirstOrDefault(x => x.Id == id);

            if (question == null) return Json(new { status = 404 });

            try
            {
                _context.Questions.Remove(question);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return Json(new { status = 500 });
            }

            return Json(new { status = 200 });
        }
    }
}
