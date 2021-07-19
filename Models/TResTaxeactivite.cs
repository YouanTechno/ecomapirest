using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResTaxeactivite
    {
        public TResTaxeactivite()
        {
            TFacturePeriodiqueTemp = new HashSet<TFacturePeriodiqueTemp>();
            TResFacture = new HashSet<TResFacture>();
        }

        public int TaxactId { get; set; }
        public int? TaxactTaxId { get; set; }
        public int? TaxactActcontId { get; set; }
        public string TaxactPlaque { get; set; }
        public int? TaxactActId { get; set; }

        public virtual TActivite TaxactAct { get; set; }
        public virtual ICollection<TFacturePeriodiqueTemp> TFacturePeriodiqueTemp { get; set; }
        public virtual ICollection<TResFacture> TResFacture { get; set; }
    }
}
