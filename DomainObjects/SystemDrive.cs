using DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public class SystemDrive : Entity
    {
        public Guid SystemDriveTypeID { get; set; }
        public SystemDriveType SystemDriveTypeType { get; set; }
        public int Size { get; set; }
        public Guid SystemID { get; set; }

        public SystemDefinition System { get; set; }
    }
}
