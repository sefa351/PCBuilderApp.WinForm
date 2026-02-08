using PCBuilder.Entities;
using PCBuilder.DataAccess;

namespace PCBuilder.Business;

public class ProductService
{
    private readonly ProductRepository _repository;

    public ProductService()
    {
        // Depoyu burada oluşturuyoruz
        _repository = new ProductRepository();
    }

   
    public List<CPU> GetCPUs() => _repository.GetCPUs();
    public List<Motherboard> GetMotherboards() => _repository.GetMotherboards();
    public List<RAM> GetRAMs() => _repository.GetRAMs();
    public List<GPU> GetGPUs() => _repository.GetGPUs();
    public List<PowerSupply> GetPSUs() => _repository.GetPowerSupplies();
    public List<Case> GetCases() => _repository.GetCases();
    public List<Storage> GetStorages() => _repository.GetStorages();
    public List<PrebuiltSystem> GetPrebuiltSystems() => _repository.GetPrebuiltSystems();
    public List<Motherboard> GetCompatibleMotherboards(int cpuId)
    {
        var cpu = GetCPUs().FirstOrDefault(c => c.Id == cpuId);
        if (cpu == null) return new List<Motherboard>();

      
        return GetMotherboards().Where(m => m.SocketType == cpu.SocketType).ToList();
    }

    // 2. Anakarta uygun RAM'leri getir
    public List<RAM> GetCompatibleRAMs(int mbId)
    {
        var mb = GetMotherboards().FirstOrDefault(m => m.Id == mbId);
        if (mb == null) return new List<RAM>();

        // DDR4 ise sadece DDR4 RAM'leri getir
        return GetRAMs().Where(r => r.MemoryType == mb.RamType).ToList();
    }

    // 3. Anakarta uygun Ekran Kartlarını getir
    public List<GPU> GetCompatibleGPUs(int mbId)
    {
        // Şimdilik hepsi uyumlu (PCIe standarttır)
        return GetGPUs();
    }
}