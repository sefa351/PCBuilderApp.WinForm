using System.Collections.Generic;
using System.Linq;
using PCBuilder.Entities;

namespace PCBuilder.DataAccess;

public class ProductRepository
{
    
    public List<PrebuiltSystem> GetPrebuiltSystems()
    {
        var allProducts = GetAllProducts();

        if (allProducts == null || !allProducts.Any()) return new List<PrebuiltSystem>();

        return new List<PrebuiltSystem>
        {
            // SİSTEM 1: FİYAT/PERFORMANS KRALI
            new PrebuiltSystem
            {
                Id = 1,
                SystemName = "Gamer X - Fiyat/Performans",
                Description = "1080p Ultra oyunculuk için en mantıklı tercih.",
                DiscountedPrice = 28500, // Toplamdan daha ucuz
                Cpu = (CPU)allProducts.FirstOrDefault(p => p.Id == 2)!,      // i5-12400F
                Mb = (Motherboard)allProducts.FirstOrDefault(p => p.Id == 11)!, // MSI Pro B760M
                Ram = (RAM)allProducts.FirstOrDefault(p => p.Id == 26)!,     // XPG Gammix D30 (Kırmızı)
                Gpu = (GPU)allProducts.FirstOrDefault(p => p.Id == 31)!,     // RTX 4060
                Storage = (Storage)allProducts.FirstOrDefault(p => p.Id == 304)!, // Kioxia 1TB NVMe
                Case = (Case)allProducts.FirstOrDefault(p => p.Id == 406)!,  // DeepCool CH560 Digital
                Psu = (PowerSupply)allProducts.FirstOrDefault(p => p.Id == 41)!   // Corsair 650W
            },

            // SİSTEM 2: BEYAZ İNCİ (WHITE AESTHETIC)
            new PrebuiltSystem
            {
                Id = 2,
                SystemName = "White Pearl - Estetik & Güç",
                Description = "2K Oyunculuk ve bembeyaz tasarım şıklığı.",
                DiscountedPrice = 62000,
                Cpu = (CPU)allProducts.FirstOrDefault(p => p.Id == 7)!,       // Ryzen 5 7600
                Mb = (Motherboard)allProducts.FirstOrDefault(p => p.Id == 15)!, // Asus Prime B650M
                Ram = (RAM)allProducts.FirstOrDefault(p => p.Id == 28)!,      // Corsair RGB Beyaz DDR5
                Gpu = (GPU)allProducts.FirstOrDefault(p => p.Id == 32)!,      // RTX 4070 SUPER
                Storage = (Storage)allProducts.FirstOrDefault(p => p.Id == 306)!, // Samsung 990 Pro 2TB
                Case = (Case)allProducts.FirstOrDefault(p => p.Id == 404)!,   // Lian Li O11 Dynamic Evo
                Psu = (PowerSupply)allProducts.FirstOrDefault(p => p.Id == 42)!   // MSI 750W Gold
            },

            // SİSTEM 3: ULTRA YAYINCI (GOD MODE)
            new PrebuiltSystem
            {
                Id = 3,
                SystemName = "Creator Pro - 4090 Beast",
                Description = "4K 144Hz oyun, render ve profesyonel yayıncılık.",
                DiscountedPrice = 145000,
                Cpu = (CPU)allProducts.FirstOrDefault(p => p.Id == 5)!,       // i9-14900K
                Mb = (Motherboard)allProducts.FirstOrDefault(p => p.Id == 13)!, // MSI Z790 Edge
                Ram = (RAM)allProducts.FirstOrDefault(p => p.Id == 29)!,      // XPG Lancer RGB 32GB DDR5
                Gpu = (GPU)allProducts.FirstOrDefault(p => p.Id == 33)!,      // RTX 4090
                Storage = (Storage)allProducts.FirstOrDefault(p => p.Id == 305)!, // WD Black SN850X
                Case = (Case)allProducts.FirstOrDefault(p => p.Id == 405)!,   // Cooler Master TD500
                Psu = (PowerSupply)allProducts.FirstOrDefault(p => p.Id == 43)!   // Asus Thor 1000W
            }
        };
    }

    public List<Product> GetAllProducts()
    {
        var products = new List<Product>();

        // ==========================================
        // 1. İŞLEMCİLER (CPU)
        // ==========================================
        products.Add(new CPU { Id = 1, Name = "Intel Core i3-12100F", Brand = "Intel", Price = 3200, SocketType = "LGA1700", CoreCount = 4, TDP = 58 });
        products.Add(new CPU { Id = 2, Name = "Intel Core i5-12400F", Brand = "Intel", Price = 4500, SocketType = "LGA1700", CoreCount = 6, TDP = 65 });
        products.Add(new CPU { Id = 3, Name = "Intel Core i5-13400F", Brand = "Intel", Price = 6500, SocketType = "LGA1700", CoreCount = 10, TDP = 65 });
        products.Add(new CPU { Id = 4, Name = "Intel Core i7-13700K", Brand = "Intel", Price = 14500, SocketType = "LGA1700", CoreCount = 16, TDP = 125 });
        products.Add(new CPU { Id = 5, Name = "Intel Core i9-14900K", Brand = "Intel", Price = 22000, SocketType = "LGA1700", CoreCount = 24, TDP = 125 });

        products.Add(new CPU { Id = 6, Name = "AMD Ryzen 5 7500F", Brand = "AMD", Price = 5800, SocketType = "AM5", CoreCount = 6, TDP = 65 });
        products.Add(new CPU { Id = 7, Name = "AMD Ryzen 5 7600", Brand = "AMD", Price = 6800, SocketType = "AM5", CoreCount = 6, TDP = 65 });
        products.Add(new CPU { Id = 8, Name = "AMD Ryzen 7 7800X3D", Brand = "AMD", Price = 13500, SocketType = "AM5", CoreCount = 8, TDP = 120 });
        products.Add(new CPU { Id = 9, Name = "AMD Ryzen 9 7950X", Brand = "AMD", Price = 19000, SocketType = "AM5", CoreCount = 16, TDP = 170 });

        // ==========================================
        // 2. ANAKARTLAR (Motherboard)
        // ==========================================
        // Intel
        products.Add(new Motherboard { Id = 10, Name = "Asus Prime H610M-K D4", Brand = "Asus", Price = 2800, SocketType = "LGA1700", RamType = "DDR4", FormFactor = "Micro-ATX", HasM2Slot = true });
        products.Add(new Motherboard { Id = 11, Name = "MSI Pro B760M-P DDR4", Brand = "MSI", Price = 3500, SocketType = "LGA1700", RamType = "DDR4", FormFactor = "Micro-ATX", HasM2Slot = true });
        products.Add(new Motherboard { Id = 12, Name = "Asus Prime Z790-P WIFI", Brand = "Asus", Price = 8500, SocketType = "LGA1700", RamType = "DDR5", FormFactor = "ATX", HasM2Slot = true });
        products.Add(new Motherboard { Id = 13, Name = "MSI MPG Z790 EDGE", Brand = "MSI", Price = 11000, SocketType = "LGA1700", RamType = "DDR5", FormFactor = "ATX", HasM2Slot = true });
        // AMD
        products.Add(new Motherboard { Id = 14, Name = "MSI PRO A620M-E", Brand = "MSI", Price = 3200, SocketType = "AM5", RamType = "DDR5", FormFactor = "Micro-ATX", HasM2Slot = true });
        products.Add(new Motherboard { Id = 15, Name = "Asus Prime B650M-K", Brand = "Asus", Price = 4800, SocketType = "AM5", RamType = "DDR5", FormFactor = "Micro-ATX", HasM2Slot = true });
        products.Add(new Motherboard { Id = 16, Name = "Gigabyte X670 Gaming X", Brand = "Gigabyte", Price = 9500, SocketType = "AM5", RamType = "DDR5", FormFactor = "ATX", HasM2Slot = true });
        // Test
        products.Add(new Motherboard { Id = 99, Name = "Eski Model Anakart (M.2 Yok)", Brand = "Generic", Price = 900, SocketType = "LGA1700", RamType = "DDR4", FormFactor = "ATX", HasM2Slot = false });

        // ==========================================
        // 3. RAMLER (YENİLER EKLENDİ)
        // ==========================================
        // DDR4
        products.Add(new RAM { Id = 20, Name = "G.Skill RipjawsV 8GB 3200MHz", Brand = "G.Skill", Price = 900, MemoryType = "DDR4", Capacity = 8, FrequencyMHz = 3200 });
        products.Add(new RAM { Id = 21, Name = "Corsair Vengeance LPX 16GB (2x8)", Brand = "Corsair", Price = 1800, MemoryType = "DDR4", Capacity = 16, FrequencyMHz = 3600 });
        products.Add(new RAM { Id = 22, Name = "Kingston Fury Beast 32GB (2x16)", Brand = "Kingston", Price = 3200, MemoryType = "DDR4", Capacity = 32, FrequencyMHz = 3200 });
        products.Add(new RAM { Id = 26, Name = "XPG Gammix D30 16GB (2x8) Kırmızı", Brand = "XPG", Price = 1600, MemoryType = "DDR4", Capacity = 16, FrequencyMHz = 3200 });
        products.Add(new RAM { Id = 27, Name = "Team T-Force Vulcan TUF 32GB (2x16)", Brand = "Team", Price = 2900, MemoryType = "DDR4", Capacity = 32, FrequencyMHz = 3600 });

        // DDR5
        products.Add(new RAM { Id = 23, Name = "Kingston Fury Beast 16GB 5200MHz", Brand = "Kingston", Price = 2100, MemoryType = "DDR5", Capacity = 16, FrequencyMHz = 5200 });
        products.Add(new RAM { Id = 24, Name = "G.Skill Trident Z5 RGB 32GB (2x16) 6000MHz", Brand = "G.Skill", Price = 4500, MemoryType = "DDR5", Capacity = 32, FrequencyMHz = 6000 });
        products.Add(new RAM { Id = 25, Name = "Corsair Dominator Platinum 64GB", Brand = "Corsair", Price = 9500, MemoryType = "DDR5", Capacity = 64, FrequencyMHz = 6400 });
        products.Add(new RAM { Id = 28, Name = "Corsair Vengeance RGB 32GB 6000MHz Beyaz", Brand = "Corsair", Price = 5200, MemoryType = "DDR5", Capacity = 32, FrequencyMHz = 6000 });
        products.Add(new RAM { Id = 29, Name = "XPG Lancer RGB 32GB 6000MHz Siyah", Brand = "XPG", Price = 4800, MemoryType = "DDR5", Capacity = 32, FrequencyMHz = 6000 });

        // ==========================================
        // 4. EKRAN KARTLARI (GPU)
        // ==========================================
        products.Add(new GPU { Id = 30, Name = "NVIDIA RTX 3060 12GB", Brand = "MSI", Price = 9500, Vram = 12, TDP = 170 });
        products.Add(new GPU { Id = 31, Name = "NVIDIA RTX 4060 8GB", Brand = "Galax", Price = 11500, Vram = 8, TDP = 115 });
        products.Add(new GPU { Id = 32, Name = "NVIDIA RTX 4070 SUPER 12GB", Brand = "Asus", Price = 26000, Vram = 12, TDP = 220 });
        products.Add(new GPU { Id = 33, Name = "NVIDIA RTX 4090 24GB", Brand = "MSI", Price = 85000, Vram = 24, TDP = 450 });
        products.Add(new GPU { Id = 34, Name = "AMD Radeon RX 6600 8GB", Brand = "Sapphire", Price = 7500, Vram = 8, TDP = 132 });
        products.Add(new GPU { Id = 35, Name = "AMD Radeon RX 7700 XT 12GB", Brand = "XFX", Price = 16500, Vram = 12, TDP = 245 });

        // ==========================================
        // 5. GÜÇ KAYNAKLARI (PSU)
        // ==========================================
        products.Add(new PowerSupply { Id = 40, Name = "FSP Performance 550W", Brand = "FSP", Price = 1500, Wattage = 550, Efficiency = "80+" });
        products.Add(new PowerSupply { Id = 41, Name = "Corsair CX650F RGB", Brand = "Corsair", Price = 2800, Wattage = 650, Efficiency = "80+ Bronze" });
        products.Add(new PowerSupply { Id = 42, Name = "MSI MAG A750GL", Brand = "MSI", Price = 3800, Wattage = 750, Efficiency = "80+ Gold" });
        products.Add(new PowerSupply { Id = 43, Name = "Asus ROG Thor 1000W", Brand = "Asus", Price = 12000, Wattage = 1000, Efficiency = "80+ Platinum" });

        // ==========================================
        // 6. DEPOLAMA (SSD) (YENİLER EKLENDİ)
        // ==========================================
        products.Add(new Storage { Id = 301, Name = "Samsung 980 Pro", Brand = "Samsung", Price = 3200, Capacity = "1 TB", Type = "NVMe M.2", ReadSpeed = 7000 });
        products.Add(new Storage { Id = 302, Name = "Crucial P3", Brand = "Crucial", Price = 1800, Capacity = "500 GB", Type = "NVMe M.2", ReadSpeed = 3500 });
        products.Add(new Storage { Id = 303, Name = "Kingston A400", Brand = "Kingston", Price = 1200, Capacity = "480 GB", Type = "SATA SSD", ReadSpeed = 500 });
        // Yeni Eklenenler
        products.Add(new Storage { Id = 304, Name = "Kioxia Exceria G2", Brand = "Kioxia", Price = 1500, Capacity = "1 TB", Type = "NVMe M.2", ReadSpeed = 2100 });
        products.Add(new Storage { Id = 305, Name = "WD Black SN850X", Brand = "Western Digital", Price = 4200, Capacity = "1 TB", Type = "NVMe M.2", ReadSpeed = 7300 });
        products.Add(new Storage { Id = 306, Name = "Samsung 990 Pro", Brand = "Samsung", Price = 6500, Capacity = "2 TB", Type = "NVMe M.2", ReadSpeed = 7450 });
        products.Add(new Storage { Id = 307, Name = "Seagate Barracuda Q1", Brand = "Seagate", Price = 2100, Capacity = "960 GB", Type = "SATA SSD", ReadSpeed = 550 });

        // ==========================================
        // 7. KASA (CASE) (YENİLER EKLENDİ)
        // ==========================================
        products.Add(new Case { Id = 401, Name = "Corsair iCUE 4000D", Brand = "Corsair", Price = 4500, FormFactor = "ATX",  HasGlassPanel = true });
        products.Add(new Case { Id = 402, Name = "MSI MAG FORGE M100R", Brand = "MSI", Price = 2200, FormFactor = "Micro-ATX",  HasGlassPanel = true });
        products.Add(new Case { Id = 403, Name = "NZXT H5 Flow", Brand = "NZXT", Price = 3800, FormFactor = "ATX", HasGlassPanel = true });
        // Yeni Eklenenler
        products.Add(new Case { Id = 404, Name = "Lian Li O11 Dynamic Evo", Brand = "Lian Li", Price = 6500, FormFactor = "ATX",  HasGlassPanel = true });
        products.Add(new Case { Id = 405, Name = "Cooler Master MasterBox TD500", Brand = "Cooler Master", Price = 3400, FormFactor = "ATX",  HasGlassPanel = true });
        products.Add(new Case { Id = 406, Name = "DeepCool CH560 Digital", Brand = "DeepCool", Price = 4100, FormFactor = "ATX", HasGlassPanel = true });
        products.Add(new Case { Id = 407, Name = "Asus Prime AP201", Brand = "Asus", Price = 3100, FormFactor = "Micro-ATX", HasGlassPanel = false }); // Mesh Panel

        return products;

    }

    public List<CPU> GetCPUs() => GetAllProducts().OfType<CPU>().ToList();
    public List<Motherboard> GetMotherboards() => GetAllProducts().OfType<Motherboard>().ToList();
    public List<RAM> GetRAMs() => GetAllProducts().OfType<RAM>().ToList();
    public List<GPU> GetGPUs() => GetAllProducts().OfType<GPU>().ToList();
    public List<PowerSupply> GetPowerSupplies() => GetAllProducts().OfType<PowerSupply>().ToList();
    public List<Storage> GetStorages() => GetAllProducts().OfType<Storage>().ToList();
    public List<Case> GetCases() => GetAllProducts().OfType<Case>().ToList();
    public List<PowerSupply> GetPSUs() => GetAllProducts().OfType<PowerSupply>().ToList();
}