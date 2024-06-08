using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Permissions.Dto
{
    public class PermissionGroupbyModuleDto
    {
        public string Module { get; set; }
        public List<string> Permissions { get; set; }
    }
}
