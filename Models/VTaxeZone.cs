using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VTaxeZone
    {
        public int ZoneId { get; set; }
        public string ZoneLibelle { get; set; }
        public int TaxfId { get; set; }
        public string TaxfLibelle { get; set; }
        public int? Nombre { get; set; }
    }
}
