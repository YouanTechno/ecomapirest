using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VFactureMois
    {
        public DateTime? Date { get; set; }
        public int TaxfId { get; set; }
        public double? Montant { get; set; }
        public int? Nombre { get; set; }
    }
}
