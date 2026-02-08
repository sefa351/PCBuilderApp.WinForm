using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Entities
{
    public class GPU : Product
    {
        public int Vram { get; set; } // Örn: 8 GB
        public int TDP { get; set; } // 250 Watt 

    }
}
