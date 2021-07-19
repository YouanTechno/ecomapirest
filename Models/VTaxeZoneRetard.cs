using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VTaxeZoneRetard
    {
        public int ZoneId { get; set; }
        public string ZoneLibelle { get; set; }
        public int TaxfId { get; set; }
        public string TaxfLibelle { get; set; }
        public int? Nombre { get; set; }
    }
}
