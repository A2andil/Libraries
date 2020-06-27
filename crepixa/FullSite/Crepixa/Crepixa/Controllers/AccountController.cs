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
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnv;

        public AccountController(AppDbContext context, IWebHostEnvironment host)
        {
            _context = context;
            _hostEnv = host;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            AccountVM vm = new AccountVM()
            {
                Account = new Account(),
                Roles = _context.Roles.ToList(),
                Countries = _context.Countries.ToList()
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult New(AccountVM model)
        {
            Account md = new Account()
            {
                FullName = model.Account.FullName,
                Email = model.Account.Email,
                Password = model.Account.Password,
                Mobile = model.Account.Mobile,
                CountryId = model.Account.CountryId,
                RoleId = model.Account.RoleId,
                PictureUrl = Helpers.FileHelper.Upload(model.FileUpload, _hostEnv.WebRootPath),
                IncludeDate = DateTime.Now
            };
            _context.Add(md);
            _context.SaveChanges();
            return RedirectToAction("Manage", "Account");
        }

        public IActionResult Manage()
        {
            return View(_context.Accounts.ToList());
        }

        public IActionResult Delete(int id)
        {
            var obj = _context.Accounts.Where(x => x.Id == id).SingleOrDefault();
            _context.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Manage", "Account");
        }
    }
}