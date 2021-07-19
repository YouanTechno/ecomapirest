using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VResFactureSoldee
    {
        public string ActLibelle { get; set; }
        public string FactCode { get; set; }
        public string CpteLibelle { get; set; }
        public string TaxLibelle { get; set; }
        public DateTime? FactDateEcheance { get; set; }
        public DateTime? PaieDate { get; set; }
        public float? FactMontant { get; set; }
        public int PaieId { get; set; }
        public int FactId { get; set; }
        public int TaxactId { get; set; }
        public int TaxId { get; set; }
        public int CpteCode { get; set; }
        public int ActcontId { get; set; }
        public int ActId { get; set; }
    }
}
