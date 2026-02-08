using Microsoft.EntityFrameworkCore;
using PCBuilder.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PCBuilderDataAccess
{
    // DbContext: EF Core'un veritabanı yönetim sınıfıdır.
    public class PCBuilderContext : DbContext
    {
        // Veritabanındaki tablolarımız
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }

        // Veritabanı ayarlarını yaptığımız yer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Veritabanı yolu (Connection String). 
            // LocalDB, Visual Studio ile gelen hazır/küçük SQL sunucusudur. Kurulum gerektirmez.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PCBuilderDB;Trusted_Connection=True;");
        }

        // Tablo ayarları (Örn: Product tablosunu diğerleriyle paylaştırma)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CPU ve Motherboard sınıfları Product'tan miras aldığı için
            // EF Core bunları tek bir tabloya (TPH) veya ayrı tablolara bölebilir.
            // Biz karışıklık olmasın diye her sınıfı kendi tablosuna ayıralım:

            modelBuilder.Entity<CPU>().ToTable("CPUs");
            modelBuilder.Entity<Motherboard>().ToTable("Motherboards");
        }
    }
}