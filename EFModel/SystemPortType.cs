using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModel
{
    public class SystemPortType : Entity
    {
        public PortType PortType { get; set; }
        public int Count { get; set; }
    }
}
