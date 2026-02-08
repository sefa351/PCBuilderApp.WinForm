using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Entities
{
    // Product sınıfından miras alıyor (: Product)
    // Böylece Id, Name, Price gibi özellikleri tekrar yazmamıza gerek kalmıyor.
    public class CPU : Product
    {
        public string SocketType { get; set; } = string.Empty; // Örn: LGA1700, AM5
        public int CoreCount { get; set; } // Çekirdek sayısı
        public int TDP { get; set; } // Güç tüketimi (Watt)
        public bool HasIntegratedGraphics { get; set; } // Dahili ekran kartı var mı?

    }
}
