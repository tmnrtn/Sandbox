using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModel
{
    public class SystemDrive : Entity
    {
        public DriveType DriveType { get; set; }
        public int Size { get; set; }
    }
}
