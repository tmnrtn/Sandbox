using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{

    public class SystemDefinition: Entity
    {
        public Guid? CPUID { get; set; }
        public CPU? CPU { get; set; }
        public Guid? GPUID { get; set; }
        public GPU? GPU { get; set; }    
        public ICollection<SystemPort>? Ports { get; set; }
        public ICollection<SystemDrive>? Drives { get; set; }
        public decimal? Weight { get; set; }
        public Guid? WeightUnitID { get; set; }
        public WeightUnit? WeightUnit { get; set; }  


    }
}
