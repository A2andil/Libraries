using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crepixa.Models;
using Crepixa.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Crepixa.Controllers
{
    public class TagController : Controller
    {

        private readonly AppDbContext _context;

        public TagController(AppDbContext context)
        {
            _context = context;
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
        public IActionResult New(Tag model)
        {
            try
            {
                var obj = _context.Tags
                                .Where(x => x.Name.Trim().ToLower() == model.Name.Trim().ToLower())
                                .SingleOrDefault();
                if (obj == null && model.Name.Trim().Length > 0)
                {
                    _context.Add(model);
                    _context.SaveChanges();
                }
            }
            catch(Exception e)
            {
                return RedirectToAction("Manage", "Tag");
            }
            return RedirectToAction("Manage", "Tag");
        }

        public IActionResult Manage()
        {
            TagsItemsVM md = new TagsItemsVM();
            md.TagsList = _context.Tags.ToList();
            return View(md);
        }

        public IActionResult Delete(int id)
        {
            var obj = _context.Tags.Where(x => x.Id == id).SingleOrDefault();
            if (obj != null)
            {
                _context.Tags.Remove(obj);
                _context.SaveChanges();
            }
            return RedirectToAction("Manage", "Tag");
        }
    }
}