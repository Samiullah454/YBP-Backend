using Abp.Application.Services;
using Abp.Domain.Repositories;

using HCA.Cities.DTO;
using HCA.States;
using HCA.States.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Cities
{
    public class CityAppService : AsyncCrudAppService<City, CityDto>
    {
        private readonly IRepository<City> _repository;
        public CityAppService(IRepository<City> repository)
            : base(repository)
        {
            _repository = repository;
        }

        public async Task<List<CityDto>> GetAllCitiesofState(int stateId)
        {
            var cities = await _repository.GetAllListAsync(city => city.StateId == stateId);
            var citiesList = ObjectMapper.Map<List<CityDto>>(cities);
            return citiesList;
        }
    }
}
