using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using HCA.Authorization.Roles;
using HCA.Permissions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Permissions
{
    public class PermissionAppService : AsyncCrudAppService<CustomPermission, Permissions.Dto.CustomPermissionDto>
    {
        private readonly IRepository<CustomPermission> _repository;
        public PermissionAppService(IRepository<CustomPermission> repository)
            : base(repository)
        {
            _repository = repository;
        }

        public override async Task<Permissions.Dto.CustomPermissionDto> CreateAsync(Permissions.Dto.CustomPermissionDto input)
        {

            if (input.Id == 0)
            {
                CustomPermission contactobj = new CustomPermission();
                ObjectMapper.Map(input, contactobj);
                await _repository.InsertAsync(contactobj);
            }
            else
            {
                if (input.isDeleted == true)
                {
                    await _repository.DeleteAsync(input.Id);
                }
                else
                {
                    var role = await _repository.GetAsync(input.Id);
                    ObjectMapper.Map(input, role);
                    await _repository.UpdateAsync(role);
                }
            }
            return input;

        }


        public async Task<List<PermissionGroupbyModuleDto>> GetPermissionsListGroupByModule(string roleid)
        {
            var permissions = _repository.GetAllIncluding().ToList();
            List<PermissionGroupbyModuleDto> finalpermissionlist = new List<PermissionGroupbyModuleDto>();
            
            return finalpermissionlist;
        }



    }
}

