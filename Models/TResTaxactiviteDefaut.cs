using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResTaxactiviteDefaut
    {
        public int TaxactId { get; set; }
        public int? TaxactActId { get; set; }
        public int? TaxactTaxId { get; set; }

        public virtual TResActivite TaxactAct { get; set; }
        public virtual TResTaxe TaxactTax { get; set; }
    }
}
