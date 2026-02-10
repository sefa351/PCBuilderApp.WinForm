using Microsoft.EntityFrameworkCore;
using PCBuilder.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PCBuilder.DataAccess
{
   
    public class PCBuilderContext : DbContext
    {
        public PCBuilderContext(DbContextOptions<PCBuilderContext> options) : base(options)
        {
        }
        // Veritabanındaki tablolarımız
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<PrebuiltSystem> PrebuiltSystems { get; set; }

     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PCBuilderDB;Trusted_Connection=True;");
        }

        
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