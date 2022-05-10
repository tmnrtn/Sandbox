using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public class SystemPort : Entity
    {
        public Guid PortTypeID { get; set; }
        public SystemPortType PortType { get; set; }
        public int Count { get; set; }

        public Guid SystemID { get; set; }

        public SystemDefinition System { get; set; }
    }
}
