using Crepixa.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crepixa.ViewModels
{
    public class ProjectVM
    {
        public string ProjectName { get; set; }

        public string Description { get; set; }

        public List<string> Tags { get; set; }

        public List<IFormFile> Photos { get; set; }

        public List<Company> Companies { get; set; }

    }
}
