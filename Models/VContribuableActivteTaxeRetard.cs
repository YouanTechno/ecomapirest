using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VContribuableActivteTaxeRetard
    {
        public int ContId { get; set; }
        public string ContNom { get; set; }
        public string ContPrenom { get; set; }
        public string ContNcc { get; set; }
        public string ContPieceCode { get; set; }
        public string ContNumPiece { get; set; }
        public string ContMatricule { get; set; }
        public DateTime? ContDateImmatriculation { get; set; }
        public string ContMatriculeAnnuel { get; set; }
        public DateTime? ContDateImmatriculationAnnuelle { get; set; }
        public string ActLibelle { get; set; }
        public string ActDescription { get; set; }
        public string ActCode { get; set; }
        public string TaxLibelle { get; set; }
        public string TaxDescription { get; set; }
        public int? TaxCpteCode { get; set; }
        public int? TaxfId { get; set; }
        public string TaxfLibelle { get; set; }
        public string TaxfDescription { get; set; }
        public int? Retard { get; set; }
        public double? MontantRetard { get; set; }
        public string QuartierLibelle { get; set; }
        public string IlotLibelle { get; set; }
        public string LotLibelle { get; set; }
        public string ContTelephone { get; set; }
        public string ContMail { get; set; }
        public int ActcontId { get; set; }
        public int? TaxactId { get; set; }
        public DateTime? FactDerniereEcheance { get; set; }
        public int ZoneId { get; set; }
    }
}
