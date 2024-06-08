using Abp.Application.Services;
using Abp.Domain.Repositories;
using HCA.States.DTO;

using HCA.Packages;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using HCA.Notification.Dto;

namespace HCA.States
{
    public class StateAppService : AsyncCrudAppService<State, StateDto>
    {
        private readonly IRepository<State> _repository;
        public StateAppService(IRepository<State> repository)
            : base(repository)
        {
            _repository = repository;
        }

        public async Task<List<StateDto>> GetAllStates()
        {
            var states = await _repository.GetAllListAsync();
            var statesList = ObjectMapper.Map<List<StateDto>>(states);
            return statesList;
        }
    }
}
