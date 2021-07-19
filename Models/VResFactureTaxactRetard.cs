using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VResFactureTaxactRetard
    {
        public int FactTaxactId { get; set; }
        public DateTime? Date { get; set; }
        public int? Nombre { get; set; }
        public double? Montant { get; set; }
    }
}
