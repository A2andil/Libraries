using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crepixa.ViewModels
{
    public class CountryVM
    {
        public string NameAr { get; set; }

        public string NameEn { get; set; }

        public IFormFile FileUpload { get; set; }
    }
}
