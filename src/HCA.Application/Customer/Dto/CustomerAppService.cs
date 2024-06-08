using Abp;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.Customer.Dto.CustomerDtos;
using HCA.Employee.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Customer.Dto
{
    public class CustomerAppService : AsyncCrudAppService<Customers, CustomerDto, int, PagedAndSortedResultRequestDto, CreateOrUpdateCustomerDto, CreateOrUpdateCustomerDto>
    {
        public CustomerAppService(IRepository<Customers, int> repository) : base(repository)
        {
        }
        public override async Task<PagedResultDto<CustomerDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = Repository.GetAllIncluding(c =>c.Sites);

            var totalCount = await query.CountAsync();

            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);

            var entities = await query.ToListAsync();

            var dtos = ObjectMapper.Map<List<CustomerDto>>(entities);

            return new PagedResultDto<CustomerDto>(totalCount, dtos);
        }
        public override async Task<CustomerDto> GetAsync(EntityDto<int> input)
        {
            var customer = await Repository.GetAllIncluding(c => c.Sites)
                                            .FirstOrDefaultAsync(c => c.Id == input.Id);

            if (customer == null)
            {
                throw new AbpException("Customer not found");
            }

            return ObjectMapper.Map<CustomerDto>(customer);
        }
    }
}
