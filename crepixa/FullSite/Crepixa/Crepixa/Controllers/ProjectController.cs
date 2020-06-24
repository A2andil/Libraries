using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crepixa.Models;
using Crepixa.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crepixa.Controllers
{
    public class ProjectController : Controller
    {

        private readonly AppDbContext _context;

        public ProjectController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult New()
        {
            return View(new ProjectVM());
        }

        public IActionResult SendTest()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Send(List<IFormFile> files, string test)
        {
           
            return Json("success");
        }

        public JsonResult GetTags()
        {
            return Json(_context.Tags.ToList());
        }
    }
}