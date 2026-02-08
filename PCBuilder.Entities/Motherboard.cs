using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Entities
{
    public class Motherboard : Product
    {
        public string SocketType { get; set; } = string.Empty; // İşlemci ile eşleşmesi gereken yer!
        public string RamType { get; set; } = string.Empty; // Örn: DDR4, DDR5
        public string FormFactor { get; set; } = string.Empty; // ATX, Micro-ATX  
        public bool HasM2Slot { get; set; } // M.2 SSD takılabilir mi?
    }
}

