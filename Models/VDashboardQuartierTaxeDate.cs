using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VDashboardQuartierTaxeDate
    {
        public int? QuartierId { get; set; }
        public string QuartierLibelle { get; set; }
        public int TaxfId { get; set; }
        public string TaxfLibelle { get; set; }
        public DateTime? Jour { get; set; }
        public double? Montant { get; set; }
        public int? Nombre { get; set; }
    }
}
