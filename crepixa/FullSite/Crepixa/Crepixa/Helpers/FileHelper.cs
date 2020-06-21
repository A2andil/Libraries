using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Crepixa.Helpers
{
    public class FileHelper
    {
        public static string[] Extension = new string[] { ".jpg", ".png", ".jpej" };

        public static string Upload(IFormFile file, string root)
        {
            string FileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string path = Path.Combine(root, Path.Combine("Content",FileName));
            file.CopyTo(new FileStream(path, FileMode.Create));
            return Path.Combine("Content", FileName);
        }
    }
}
