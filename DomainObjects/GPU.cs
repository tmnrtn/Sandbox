using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public enum GPUType
    {
        Discrete, OnBoard
    }
    public class GPU : Entity
    {
        public GPUType GPUType { get; set; }
    }
}
