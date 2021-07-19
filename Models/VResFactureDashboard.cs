using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VResFactureDashboard
    {
        public int? CommuneId { get; set; }
        public string CommuneLibelle { get; set; }
        public int? QuartierId { get; set; }
        public string QuartierLibelle { get; set; }
        public int TaxfId { get; set; }
        public string TaxfLibelle { get; set; }
        public int? Nombre { get; set; }
        public double? Montant { get; set; }
        public DateTime? FactDateEcheance { get; set; }
        public bool FactBEtatReglement { get; set; }
        public string CodGeoQuartier { get; set; }
        public int? FactPotentiel { get; set; }
    }
}
