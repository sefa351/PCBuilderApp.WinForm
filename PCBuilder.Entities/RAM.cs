using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Entities
{
    public class RAM : Product
    {
        public string MemoryType { get; set; } = string.Empty; //DDR4, DDR5
        public int Capacity { get; set; } // Kaç GB Olduğu
        public int FrequencyMHz { get; set; } // 3200, 3600 MHz
    }
}
