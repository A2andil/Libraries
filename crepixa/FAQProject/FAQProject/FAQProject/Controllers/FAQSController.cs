using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAQProject.Models;
using FAQProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FAQProject.Controllers
{
    public class FAQSController : Controller
    {
        private readonly AppDbContext _context;
        public FAQSController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var lst = _context.FAQS.Where(m => m.IsHidden == false).ToList();
            var model = new ListFAQVM { Questions = lst };
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreatedFAQVM model)
        {
            if (ModelState.IsValid)
            {
                FAQ fq = new FAQ
                {
                    Question = model.Question,
                    Answer = model.Answer,
                    IsHidden = false
                };
                _context.FAQS.Add(fq);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return NotFound();
        }

        public IActionResult Edit()
        {
            var lst = _context.FAQS.ToList();
            var model = new ListFAQVM { Questions = lst };
            return View(model);
        }

        public IActionResult Eye(int id)
        {
            var faq = _context.FAQS.Where(m => m.Id == id).SingleOrDefault();
            if (faq != null)
            {
                faq.IsHidden = !faq.IsHidden;
                _context.SaveChanges();
            }
            return RedirectToAction("Edit", "FAQS");
        }

        public IActionResult Modify(int id)
        {
            var model = _context.FAQS.Where(a => a.Id == id).SingleOrDefault();
            if (model != null)
                return View(model);
            return RedirectToAction("Edit", "FAQS");
        }
        [HttpPost]
        public IActionResult Modify(FAQ model)
        {
            _context.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Edit", "FAQS");
        }

    }
}