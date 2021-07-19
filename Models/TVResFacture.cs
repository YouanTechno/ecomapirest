using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TVResFacture
    {
        public string FactCode { get; set; }
        public string ActLibelle { get; set; }
        public string CpteLibelle { get; set; }
        public string TaxLibelle { get; set; }
        public DateTime? FactDateEcheance { get; set; }
        public int? FactMontant { get; set; }
        public int? FactId { get; set; }
        public int? TaxactId { get; set; }
        public int? TaxId { get; set; }
        public string CpteCode { get; set; }
        public int? ActcontId { get; set; }
        public int? ActId { get; set; }
        public int? ActcontZoneId { get; set; }
        public string ActcontPlaque { get; set; }
        public string ActcontNom { get; set; }
        public int? ActcontRefId { get; set; }
        public string Libelle { get; set; }
        public int? CommuneId { get; set; }
        public int? QuartierId { get; set; }
        public int? IlotId { get; set; }
        public int? LotId { get; set; }
        public string CommuneLibelle { get; set; }
        public string QuartierLibelle { get; set; }
        public string IlotLibelle { get; set; }
        public string LotLibelle { get; set; }
        public bool? FactBEtatReglement { get; set; }
        public int? ContId { get; set; }
        public string ContNom { get; set; }
        public string ContPrenom { get; set; }
        public string ContNcc { get; set; }
        public int? FacPotentiel { get; set; }
    }
}
