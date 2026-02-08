using PCBuilder.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PCBuilder.DataAccess
{
    public class ProductRepository
    {
        // Tüm ürünleri (Hem CPU hem Anakart) tek listede döndüren bir metot
        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();

            // --- İŞLEMCİLER ---
            products.Add(new CPU
            {
                Id = 1,
                Name = "Intel Core i5-13400F",
                Brand = "Intel",
                Price = 5500,
                SocketType = "LGA1700",
                CoreCount = 10,
                TDP = 65,
                ImageUrl = "https://example.com/i5.jpg"
            });

            products.Add(new CPU
            {
                Id = 2,
                Name = "AMD Ryzen 5 7600",
                Brand = "AMD",
                Price = 6200,
                SocketType = "AM5",
                CoreCount = 6,
                TDP = 65,
                ImageUrl = "https://example.com/ryzen5.jpg"
            });

            // --- ANAKARTLAR ---
            products.Add(new Motherboard
            {
                Id = 3,
                Name = "Asus Prime B760M-K",
                Brand = "Asus",
                Price = 3800,
                SocketType = "LGA1700", // Intel ile uyumlu
                RamType = "DDR5",
                FormFactor = "mATX"
            });

            products.Add(new Motherboard
            {
                Id = 4,
                Name = "MSI PRO B650M-A",
                Brand = "MSI",
                Price = 4500,
                SocketType = "AM5", // AMD ile uyumlu
                RamType = "DDR5",
                FormFactor = "mATX"
            });

            return products;
        }

        // Sadece İşlemcileri filtreleyip getiren metot
        public List<CPU> GetCPUs()
        {
            // GetAllProducts içinden sadece CPU tipinde olanları al
            return GetAllProducts().OfType<CPU>().ToList();
        }

        // Sadece Anakartları getiren metot
        public List<Motherboard> GetMotherboards()
        {
            return GetAllProducts().OfType<Motherboard>().ToList();
        }
    }
}