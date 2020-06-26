using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Crepixa.Models;
using Crepixa.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crepixa.Controllers
{
    public class ProjectController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _host;

        public ProjectController(AppDbContext context, IWebHostEnvironment host)
        {
            _context = context;
            _host = host;
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Send(List<IFormFile> photos, string name, string desc, List<string> tags)
        {
            string TagString = "";
            for (int i = 0; i < tags.Count; i++)
            {
                bool is_to_add = true;
                for (int j = i + 1; j < tags.Count; j++)
                    if (tags[i].ToLower() == tags[j].ToLower()) is_to_add = false;
                if (is_to_add) TagString += tags[i] + ";";
            }
            TagString = TagString.Substring(0, TagString.Length - 1);

            string PhotoString = "";
            for (int i = 0; i < photos.Count; i++)
                PhotoString += SavaPhoto(photos[i]) + ";";
            PhotoString = PhotoString.Substring(0, PhotoString.Length - 1);

            Project obj = new Project()
            {
                Name = name,
                Description = desc,
                ImageUrls = PhotoString,
                Tags = TagString
            };
            _context.Add(obj);
            _context.SaveChanges();

            return Json("success");
        }

        private string SavaPhoto(IFormFile file)
        {
            return Helpers.FileHelper.Upload(file, _host.WebRootPath);
        }

        public JsonResult GetTags()
        {
            return Json(_context.Tags.ToList());
        }

        public IActionResult Manage()
        {
            return View(_context.Projects.ToList());
        }

        public IActionResult Delete(int id)
        {
            var obj = _context.Projects.Where(x => x.Id == id).SingleOrDefault();
            if (obj != null)
            {
                _context.Remove(obj);
                _context.SaveChanges();
            }
            return RedirectToAction("Manage", "Project");
        }
    }
}