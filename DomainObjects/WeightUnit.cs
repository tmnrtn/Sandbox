
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public class WeightUnit : Entity
    {
        public bool IsMaster { get; set; }
        public decimal ConversionFactor { get; set; }

    }
}
