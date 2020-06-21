using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crepixa.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public string EmployeeIds { get; set; }

        public string TagsIds { get; set; }

        public string ImageUrls { get; set; }
    }
}
