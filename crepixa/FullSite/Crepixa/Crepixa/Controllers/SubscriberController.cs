using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crepixa.Models;
using Crepixa.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Crepixa.Controllers
{
    public class SubscriberController : Controller
    {
        private readonly AppDbContext _context;

        public SubscriberController(AppDbContext context)
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
        public IActionResult New(Subscriber model)
        {
            var obj = _context.Subscribers
                .Where(x => x.Name.Trim().ToLower() == model.Name.Trim().ToLower()
                && x.Email.Trim().ToLower() == model.Email.Trim().ToLower()).SingleOrDefault();
            if (obj == null)
            {
                _context.Add(model);
                _context.SaveChanges();
            }
            return RedirectToAction("Manage", "Subscriber");
        }


        public IActionResult Manage()
        {
            return View(_context.Subscribers.ToList());
        }

        public IActionResult Delete(int id)
        {
            var obj = _context.Subscribers.Where(x => x.Id == id).SingleOrDefault();
            if (obj != null)
            {
                _context.Remove(obj);
                _context.SaveChanges();
            }
            return RedirectToAction("Manage", "Subscriber");
        }

        public IActionResult Send()
        {
            var lst = _context.Subscribers.ToList();
            List<SubscriberItem> model = new List<SubscriberItem>();
            for (int i = 0; i < lst.Count; i++)
            {
                SubscriberItem item = new SubscriberItem
                {
                    Name = lst[i].Name,
                    Email = lst[i].Email,
                    Ischecked = false
                };
                model.Add(item);
            }
            return View(model);
        }

        [HttpPost]
        public JsonResult Send(SendVM model)
        {
            return Json("success");
        }
    }
}