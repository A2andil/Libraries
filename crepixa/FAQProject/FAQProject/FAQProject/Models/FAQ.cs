using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQProject.Models
{
    public class FAQ
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public bool IsHidden { get; set; }
    }
}
