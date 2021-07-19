using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VResFacture
    {
        public string ActLibelle { get; set; }
        public string FactCode { get; set; }
        public string CpteLibelle { get; set; }
        public string TaxLibelle { get; set; }
        public DateTime? FactDateEcheance { get; set; }
        public float? FactMontant { get; set; }
        public int FactId { get; set; }
        public int TaxactId { get; set; }
        public int TaxId { get; set; }
        public int? CpteCode { get; set; }
        public int ActcontId { get; set; }
        public int ActId { get; set; }
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
        public bool FactBEtatReglement { get; set; }
        public int ContId { get; set; }
        public string ContNom { get; set; }
        public string ContPrenom { get; set; }
        public string ContNcc { get; set; }
        public string Expr1 { get; set; }
        public int? TaxfId { get; set; }
        public string TaxfLibelle { get; set; }
        public string TaxfDescription { get; set; }
        public string TaxfUrlImage { get; set; }
        public int? Expr2 { get; set; }
        public int? ZoneSecId { get; set; }
        public bool FactBAbandon { get; set; }
        public DateTime? FactDateaBandon { get; set; }
        public int? FactAbandonAgId { get; set; }
        public string FactAbandonMotif { get; set; }
        public string FactLibelle { get; set; }
        public DateTime? FactPeriodeDebut { get; set; }
        public DateTime? FactPeriodeFin { get; set; }
        public DateTime? FactDateEmission { get; set; }
        public int? ZoneId { get; set; }
        public int? Expr3 { get; set; }
        public int? Expr4 { get; set; }
        public string Expr5 { get; set; }
        public string Expr6 { get; set; }
        public int? Expr7 { get; set; }
        public int? Expr8 { get; set; }
        public string Expr9 { get; set; }
        public string Expr10 { get; set; }
        public int? FactPotentiel { get; set; }
    }
}
