using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VZoneEauElectricite
    {
        public int? QuartierId { get; set; }
        public string QuartierLibelle { get; set; }
        public int? Eau { get; set; }
        public int? Electricite { get; set; }
    }
}
