using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crepixa.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string PictureUrl { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public float Rate { get; set; }

        public int CompanyId { get; set; }

        public int CountryId { get; set; }

        public DateTime IncludeDate { get; set; }

        public int Salary { get; set; }

        public int RoleId { get; set; }
    }
}
