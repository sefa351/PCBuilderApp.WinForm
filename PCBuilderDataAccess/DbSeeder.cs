using PCBuilder.Entities;
using Microsoft.EntityFrameworkCore;

namespace PCBuilder.DataAccess
{
    public static class DbSeeder
    {
        public static void Seed(PCBuilderContext context)
        {
           
            if (!context.CPUs.Any())
            {
                var eskiRepo = new ProductRepository();
                var transferEdilecekUrunler = eskiRepo.GetAllProducts();

               
                foreach (var urun in transferEdilecekUrunler)
                {
                    urun.Id = 0;
                }

                context.AddRange(transferEdilecekUrunler);
                context.SaveChanges();
            }

           
            if (!context.PrebuiltSystems.Any())
            {
                var repo = new ProductRepository();
                var eskiSistemler = repo.GetPrebuiltSystems(); 

             
                var dbCPUs = context.CPUs.ToList();
                var dbMotherboards = context.Motherboards.ToList();
                var dbRAMs = context.RAMs.ToList();
                var dbGPUs = context.GPUs.ToList();
                var dbStorages = context.Storages.ToList();
                var dbCases = context.Cases.ToList();
                var dbPSUs = context.PowerSupplies.ToList();

                foreach (var eskiSistem in eskiSistemler)
                {
                   

                    var newCpu = dbCPUs.FirstOrDefault(x => x.Name == eskiSistem.Cpu?.Name);
                    var newMb = dbMotherboards.FirstOrDefault(x => x.Name == eskiSistem.Mb?.Name);
                    var newRam = dbRAMs.FirstOrDefault(x => x.Name == eskiSistem.Ram?.Name);
                    var newGpu = dbGPUs.FirstOrDefault(x => x.Name == eskiSistem.Gpu?.Name);
                    var newStorage = dbStorages.FirstOrDefault(x => x.Name == eskiSistem.Storage?.Name);
                    var newCase = dbCases.FirstOrDefault(x => x.Name == eskiSistem.Case?.Name);
                    var newPsu = dbPSUs.FirstOrDefault(x => x.Name == eskiSistem.Psu?.Name);

                    if (newCpu != null && newMb != null && newRam != null && newGpu != null &&
                        newStorage != null && newCase != null && newPsu != null)
                    {
                        var yeniSistem = new PrebuiltSystem
                        {
                            SystemName = eskiSistem.SystemName,
                            Description = eskiSistem.Description,
                            DiscountedPrice = eskiSistem.DiscountedPrice,
                            ImageUrl = eskiSistem.ImageUrl,

                            Cpu = newCpu,
                            Mb = newMb,
                            Ram = newRam,
                            Gpu = newGpu,
                            Storage = newStorage,
                            Case = newCase,
                            Psu = newPsu
                        };
                        context.PrebuiltSystems.Add(yeniSistem);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}