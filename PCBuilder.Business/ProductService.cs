using PCBuilder.Entities;
using PCBuilder.DataAccess;
using Microsoft.EntityFrameworkCore; 

namespace PCBuilder.Business;

public class ProductService
{
    
    private readonly PCBuilderContext _context;

    public ProductService(PCBuilderContext context)
    {
        _context = context;
    }

    // VERİLER SQL'DEN GELİYOR 
    public List<CPU> GetCPUs() => _context.CPUs.ToList();
    public List<Motherboard> GetMotherboards() => _context.Motherboards.ToList();
    public List<RAM> GetRAMs() => _context.RAMs.ToList();
    public List<GPU> GetGPUs() => _context.GPUs.ToList();
    public List<PowerSupply> GetPSUs() => _context.PowerSupplies.ToList();
    public List<Case> GetCases() => _context.Cases.ToList();
    public List<Storage> GetStorages() => _context.Storages.ToList();
    public List<PrebuiltSystem> GetPrebuiltSystems()
    {
        return _context.PrebuiltSystems
                       .Include(p => p.Cpu)      // İşlemciyi getir
                       .Include(p => p.Mb)       // Anakartı getir
                       .Include(p => p.Ram)      // RAM'i getir
                       .Include(p => p.Gpu)      // Ekran Kartını getir
                       .Include(p => p.Psu)      // PSU'yu getir
                       .Include(p => p.Storage)  // SSD'yi getir
                       .Include(p => p.Case)     // Kasayı getir
                       .ToList();
    }


    public List<Motherboard> GetCompatibleMotherboards(int cpuId)
    {
        var cpu = _context.CPUs.FirstOrDefault(c => c.Id == cpuId);
        if (cpu is null) return new();

        return _context.Motherboards
                       .Where(m => m.SocketType == cpu.SocketType)
                       .ToList();
    }

    public List<RAM> GetCompatibleRAMs(int mbId)
    {
        var mb = _context.Motherboards.FirstOrDefault(m => m.Id == mbId);
        if (mb is null) return new();

        return _context.RAMs
                       .Where(r => r.MemoryType == mb.RamType)
                       .ToList();
    }

    public List<GPU> GetCompatibleGPUs(int mbId) => _context.GPUs.ToList();
}