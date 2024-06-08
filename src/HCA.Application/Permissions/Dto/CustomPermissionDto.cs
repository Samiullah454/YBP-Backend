using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HCA.Permissions.Dto
{
    [AutoMap(typeof(CustomPermission))]
    public class CustomPermissionDto : EntityDto
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }
        public bool isDeleted { get; set; }
    }
}
