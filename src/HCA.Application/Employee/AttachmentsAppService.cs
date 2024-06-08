using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using HCA.Employee.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCA.MultiTenancy.Dto;
using HCA.MultiTenancy;
using Abp.Linq.Extensions;
using Abp.Runtime.Session;

namespace HCA.Employee
{
    public class AttachmentsAppService : AsyncCrudAppService<Attachments, AttachmentsDto, int, GetAllAttachmentsInput, AttachmentsCreateOrUpdateDto, AttachmentsCreateOrUpdateDto>
    {
        private readonly IFileUploadService _fileUploadService;
        private readonly IAbpSession _session;

        public AttachmentsAppService(IRepository<Attachments, int> repository, IFileUploadService fileUploadService, IAbpSession session)
            : base(repository)
        {
            _fileUploadService = fileUploadService;
            _session = session;
        }

        public override async Task<AttachmentsDto> CreateAsync(AttachmentsCreateOrUpdateDto input)
        {
            var filePath = await _fileUploadService.SaveFileAsync(input.FileName, input.FileContent, input.TechnicianId);


            var attachment = ObjectMapper.Map<Attachments>(input);
            attachment.FileContent = null;
            attachment.FilePath = filePath;
            await Repository.InsertAsync(attachment);

            return MapToEntityDto(attachment);
        }

        protected override IQueryable<Attachments> CreateFilteredQuery(GetAllAttachmentsInput input)
        {
            return base.CreateFilteredQuery(input)
                 .WhereIf(input.TechnicianId.HasValue, t => t.TechnicianId == input.TechnicianId.Value);
        }

        //public override async Task<PagedResultDto<AttachmentsDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        //{
        //    //return base.GetAllAsync(input);
         
        //        var query = Repository.GetAll();

        //    // Check if TechnicianId filter is provided
        //    if (technicianId.HasValue)
        //    {
        //        // Apply the filter
        //        query = query.Where(a => a.TechnicianId == technicianId.Value);
        //    }

        //    var attachments = await AsyncQueryableExecuter.ToListAsync(query.PageBy(input));

        //        return new PagedResultDto<AttachmentsDto>
        //        {
        //            TotalCount = query.Count(),
        //            Items = ObjectMapper.Map<List<AttachmentsDto>>(attachments)
        //        };
           
        //}

    }

}
