using Abp.Application.Services;
using Abp.Dependency;
using Abp.Domain.Repositories;

using HCA.Packages;
using HCA.Transactions.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HCA.Transactions
{
    public class TransactionAppService : AsyncCrudAppService<Transactions, TransactionDto>
    {
        private readonly IRepository<Transactions> _repository;
        public TransactionAppService(IRepository<Transactions> repository)
            : base(repository)
        {
            _repository = repository;
        }
        public override async Task<TransactionDto> CreateAsync(TransactionDto input)
        {
            Transactions transaction = new Transactions();

            ObjectMapper.Map(input, transaction);
            await _repository.InsertAsync(transaction);
            return input;
        }
    }
}
