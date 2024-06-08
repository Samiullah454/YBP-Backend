using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.WebSite_Configuration.Service;
using HCA.Website_Configurations.Services.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCA.Website_Configurations.Services
{
    public class ServicesAppService : AsyncCrudAppService<Section, SectionDTO, int, PagedAndSortedResultRequestDto>
    {
        private readonly IRepository<Service> _serviceRepository;
        private readonly IRepository<Pricing> _pricingRepository;
        private readonly IRepository<Item> _itemRepository;

        public ServicesAppService(
            IRepository<Section, int> repository,
            IRepository<Service> serviceRepository,
            IRepository<Pricing> pricingRepository,
            IRepository<Item> itemRepository)
            : base(repository)
        {
            _serviceRepository = serviceRepository;
            _pricingRepository = pricingRepository;
            _itemRepository = itemRepository;
        }

        public override async Task<PagedResultDto<SectionDTO>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = Repository.GetAllIncluding(s => s.Services, s => s.Pricings, s => s.ScheduleItems, s => s.Features, s => s.FactAndFigures);
            var sections = await AsyncQueryableExecuter.ToListAsync(query);

            var dtos = ObjectMapper.Map<List<SectionDTO>>(sections);

            foreach (var sectionDto in dtos)
            {
                sectionDto.Services = ObjectMapper.Map<List<ServiceDTO>>(sections.FirstOrDefault(s => s.Id == sectionDto.Id)?.Services);

                sectionDto.Pricings = ObjectMapper.Map<List<PricingDto>>(sections.FirstOrDefault(s => s.Id == sectionDto.Id)?.Pricings);

                foreach (var pricingDto in sectionDto.Pricings)
                {
                    pricingDto.Items = ObjectMapper.Map<List<ItemDto>>(_itemRepository.GetAll().Where(i => i.PricingId == pricingDto.Id));
                }
            }

            return new PagedResultDto<SectionDTO>(dtos.Count, dtos);
        }
    }
}