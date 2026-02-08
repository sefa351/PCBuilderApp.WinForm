using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Entities
{
    // "abstract" demek: Bu sınıftan tek başına nesne üretilemez, 
    // sadece miras alınabilir demektir. Çünkü "Ürün" diye bir şey satılmaz, "İşlemci" satılır.
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Boş gelmesin diye varsayılan değer
        public string Brand { get; set; } = string.Empty; // Marka (Asus, Intel vb.)
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } // Para birimleri için decimal kullanılır
        public string? ImageUrl { get; set; }  // Soru işareti (?) "bu alan boş olabilir" demektir.
    }
}
