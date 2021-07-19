using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VEtatRecette
    {
        public string FactLibelle { get; set; }
        public DateTime? FactDateEcheance { get; set; }
        public DateTime? Expr1 { get; set; }
        public float? Expr2 { get; set; }
        public string ActLibelle { get; set; }
        public string ContNom { get; set; }
        public string ContPrenom { get; set; }
        public string ContTelephone { get; set; }
        public string ContMail { get; set; }
        public int ZoneId { get; set; }
        public int? ZoneSecId { get; set; }
        public bool FactBEtatReglement { get; set; }
        public int TaxId { get; set; }
        public int? TaxTaxfId { get; set; }
        public int? Expr3 { get; set; }
        public int TaxfId { get; set; }
        public string TaxfLibelle { get; set; }
        public int AgId { get; set; }
        public string AgNom { get; set; }
        public string AgPrenoms { get; set; }
        public int PaieId { get; set; }
        public int? PaieFactId { get; set; }
        public int? PaieFactAgId { get; set; }
        public float? PaieMontant { get; set; }
        public DateTime? PaieDate { get; set; }
        public int? PaieColId { get; set; }
        public int? PaieScValId { get; set; }
    }
}
