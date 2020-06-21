using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crepixa.Models;
using Crepixa.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Crepixa.Controllers
{
    public class CountryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _host;

        public CountryController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _host = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(CountryVM model)
        {
            try
            {
                var obj = _context.Countries
                          .Where(x => 
                           x.NameAr.Trim().ToLower() == model.NameAr.Trim().ToLower()
                           && x.NameEn.Trim().ToLower() == model.NameEn.Trim().ToLower())
                           .SingleOrDefault();

                if (obj == null 
                    && model.NameAr.Trim().Length > 0 && model.NameAr.Trim().Length > 0) {
                    Country country = new Country
                    {
                        NameAr = model.NameAr,
                        NameEn = model.NameEn
                    };
                    country.ImageUrl 
                        = Helpers.FileHelper.Upload(model.FileUpload, _host.WebRootPath);
                    _context.Add(country);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("Manage", "Country");
            }
            return RedirectToAction("Manage", "Country");
        }

        public IActionResult Manage()
        {
            IEnumerable<Country> lst = _context.Countries;
            return View(lst);
        }

        public IActionResult Delete(int id)
        {
            var obj = _context.Countries.Where(x => x.Id == id).SingleOrDefault();
            if (obj != null)
            {
                _context.Remove(obj);
                _context.SaveChanges();
            }
            return RedirectToAction("Manage", "Country");
        }
    }
}