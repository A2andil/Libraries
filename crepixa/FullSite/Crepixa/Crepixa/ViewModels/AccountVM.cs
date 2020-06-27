using Crepixa.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crepixa.ViewModels
{
    public class AccountVM
    {
        public List<Role> Roles { get; set; }

        public List<Country> Countries { get; set; }

        public Account Account { get; set; }

        public IFormFile FileUpload { get; set; }

    }
}
