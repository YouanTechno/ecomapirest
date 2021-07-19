using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VEtatCollecte
    {
        public int ColId { get; set; }
        public string TaxLibelle { get; set; }
        public string AgNom { get; set; }
        public string AgPrenoms { get; set; }
        public DateTime ColDate { get; set; }
        public DateTime? PaieDate { get; set; }
        public float ColMontant { get; set; }
        public string ContNom { get; set; }
        public string ContPrenom { get; set; }
        public string ActLibelle { get; set; }
        public int? TaxTaxfId { get; set; }
        public int? TaxfId { get; set; }
        public string TaxfLibelle { get; set; }
        public int FactId { get; set; }
        public float? FactMontant { get; set; }
        public string FactLibelle { get; set; }
        public bool FactBAbandon { get; set; }
        public DateTime? FactDateaBandon { get; set; }
        public int AcolId { get; set; }
        public string AcolMatricule { get; set; }
        public string AcolNom { get; set; }
        public string AcolPrenom { get; set; }
        public DateTime? FactDateEcheance { get; set; }
        public bool FactBEtatReglement { get; set; }
        public int? ZoneSecId { get; set; }
        public int ZoneId { get; set; }
    }
}
