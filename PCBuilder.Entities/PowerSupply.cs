using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Entities
{
    public class PowerSupply : Product
    {
        public int Wattage { get; set; }       // Örn: 750 (Toplam TDP'den büyük olmalı)
        public string? Efficiency { get; set; } // Örn: "80+ Gold"
    }
}
