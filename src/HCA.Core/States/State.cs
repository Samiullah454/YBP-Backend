using Abp.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.States
{
    public class State : Entity
    {
        public string StateName { get; set; }
    }
}
