using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Offer
{
    public class OfferAppService : AsyncCrudAppService<Offers.Offer, OfferDto, int>
    {
        public OfferAppService(IRepository<Offers.Offer, int> repository) : base(repository)
        {
        }
    }
}