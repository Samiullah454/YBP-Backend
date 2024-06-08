using Abp.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Cities
{
    public class City : Entity
    {
        public int StateId { get; set; }
        public string CityName { get; set; }
    }
}
