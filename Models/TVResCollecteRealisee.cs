using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TVResCollecteRealisee
    {
        public int ColId { get; set; }
        public string ActcontPlaque { get; set; }
        public string FactCode { get; set; }
        public string TaxLibelle { get; set; }
        public string ActLibelle { get; set; }
        public string Zone { get; set; }
        public DateTime? ColDate { get; set; }
        public int? ColMontant { get; set; }
        public int? ZoneId { get; set; }
        public int? FactMontant { get; set; }
        public string AcolMatricule { get; set; }
        public bool? ColBExportPaiement { get; set; }
        public int? AcolId { get; set; }
        public int? CommuneId { get; set; }
        public int? QuartierId { get; set; }
        public int? IlotId { get; set; }
        public int? LotId { get; set; }
        public string CommuneLibelle { get; set; }
        public string QuartierLibelle { get; set; }
        public string IlotLibelle { get; set; }
        public string LotLibelle { get; set; }
    }
}
