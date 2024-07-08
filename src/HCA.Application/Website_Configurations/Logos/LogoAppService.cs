using Abp.Application.Services;
using Abp.Domain.Repositories;
using HCA.WebSite_Configuration.Logo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Website_Configurations.Logos
{
    public class LogoAppService : AsyncCrudAppService<Logo, LogoDto, int>
    {
        public LogoAppService(IRepository<Logo, int> repository) : base(repository)
        {
        }
    }
}