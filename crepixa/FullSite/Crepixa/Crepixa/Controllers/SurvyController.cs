using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crepixa.Models;
using Crepixa.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Crepixa.Controllers
{
    public class SurvyController : Controller
    {
        private readonly AppDbContext _context;
        public SurvyController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Manage()
        {
            return View(_context.Surveies.ToList());
        }

        public IActionResult Optional()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Optional(OptionalVM model)
        {
            try
            {
                SurveyOption option = new SurveyOption()
                {
                    Options = model.A + ";" + model.B + ";" + model.C + ";" + model.D
                };
                _context.Add(option);
                _context.SaveChanges();

                Survey srv = new Survey()
                {
                    Question = model.Question,
                    OptionsId = option.Id
                };
                _context.Add(srv);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return RedirectToAction("Manage", "Survy");
        }

        public IActionResult Ordinary()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ordinary(Survey model)
        {
            try
            {
                Survey srv = new Survey()
                {
                    Question = model.Question,
                    OptionsId = -1
                };
                _context.Add(srv);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return RedirectToAction("Manage", "Survy");
        }

        public IActionResult Delete(int id)
        {
            var obj = _context.Surveies.Where(x => x.Id == id).SingleOrDefault();
            _context.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Manage", "Survy");
        }
    }
}