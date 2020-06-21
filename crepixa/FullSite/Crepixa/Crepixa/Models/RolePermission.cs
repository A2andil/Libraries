using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crepixa.Models
{
    public class RolePermission
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public string PermissionIds { get; set; }
    }
}
