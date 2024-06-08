using Abp.Application.Services;
using Abp.Dependency;
using Abp.Domain.Repositories;
using HCA.Subscription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Subscriptions
{
    public class TenantPackageSubscriptionAppService: AsyncCrudAppService<TenantPackageSubscription, TenantPackageSubscriptionDto>, ITransientDependency
    {
        private readonly IRepository<TenantPackageSubscription> _repository;
        private readonly IIocResolver _iocResolver;
        public TenantPackageSubscriptionAppService(IRepository<TenantPackageSubscription> repository, IIocResolver iocResolver)
           : base(repository)
        {
            _repository = repository;
            _iocResolver = iocResolver;

        }
    }
 }
