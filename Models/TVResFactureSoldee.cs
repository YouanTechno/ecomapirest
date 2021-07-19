using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TVResFactureSoldee
    {
        public string FactCode { get; set; }
        public string ActLibelle { get; set; }
        public string CpteLibelle { get; set; }
        public string TaxLibelle { get; set; }
        public DateTime? FactDateEcheance { get; set; }
        public DateTime? PaieDate { get; set; }
        public int? FactMontant { get; set; }
        public int? PaieId { get; set; }
        public int? FactId { get; set; }
        public int? TaxactId { get; set; }
        public int? TaxId { get; set; }
        public int? CpteCode { get; set; }
        public int? ActcontId { get; set; }
        public string ActId { get; set; }
    }
}
