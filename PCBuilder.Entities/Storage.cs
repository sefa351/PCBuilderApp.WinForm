using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Entities
{
    public class Storage : Product
    {
        public string? Capacity { get; set; } // 500GB, 1TB
        public string? Type { get; set; }     // NVMe, SATA
        public int ReadSpeed { get; set; }    // 3500 MB/s
    }
}
