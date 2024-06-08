using HCA.Permissions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Permissions
{
    public interface IPermissionAppService
    {
        Task<List<PermissionGroupbyModuleDto>> GetPermissionsListGroupByModule();
    }
}
