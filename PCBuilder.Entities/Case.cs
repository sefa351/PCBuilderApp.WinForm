using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Entities;

public class Case : Product
{
    public string? FormFactor { get; set; } // Örn: ATX, Micro-ATX, ITX
    public bool HasGlassPanel { get; set; } // Cam panel var mı?
}
