using PCBuilder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Entities;

public class PrebuiltSystem
{
    public int Id { get; set; }
    public string SystemName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal DiscountedPrice { get; set; }
    public CPU Cpu { get; set; } = new();
    public Motherboard Mb { get; set; } = new();
    public RAM Ram { get; set; } = new();
    public GPU Gpu { get; set; } = new();
    public PowerSupply Psu { get; set; } = new();
    public Storage Storage { get; set; } = new(); 
    public Case Case { get; set; } = new();       
}