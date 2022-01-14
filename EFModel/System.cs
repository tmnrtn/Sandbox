using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModel
{
    public class System: Entity
    {
        public CPU CPU { get; set; }
        public GPU GPU { get; set; }
        public List<SystemPortType> Ports { get; set; }
        public List<SystemDrive> Drives { get; set; }
        public decimal Weight { get; set; }
        public WeightUnit WeightUnit { get; set; }


    }
}
