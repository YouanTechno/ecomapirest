using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TVResFactureDashboard
    {
        public int DqtId { get; set; }
        public int? DqtCommuneId { get; set; }
        public string DqtCommuneLibelle { get; set; }
        public int? DqtQuartierId { get; set; }
        public string DqtQuartierLibelle { get; set; }
        public int? DqtTaxfId { get; set; }
        public string DqtTaxfLibelle { get; set; }
        public int? DqtMontant { get; set; }
        public int? DqtNombre { get; set; }
        public DateTime? DqtDate { get; set; }
        public bool? DqtBEtatReglement { get; set; }
        public int? DqtPotentiel { get; set; }
    }
}
