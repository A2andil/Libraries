using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crepixa.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crepixa.Controllers
{
    public class CompanyController : Controller
    {
        private readonly AppDbContext _context;

        public CompanyController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manage()
        {
            return View(_context.Companies.ToList());
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(Company model)
        {
            var obj = _context.Companies
                .Where(x => x.Email.Trim().ToLower() == model.Email.Trim().ToLower())
                .SingleOrDefault();
            if (obj == null)
            {
                _context.Add(model);
                _context.SaveChanges();
            }
            return RedirectToAction("Manage", "Company");
        }

        public IActionResult Delete(int id)
        {
            var obj = _context.Companies.Where(x => x.Id == id).SingleOrDefault();
            if (obj != null) _context.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Manage", "Company");
        }
    }
}