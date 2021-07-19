using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResTaxvaleur
    {
        public int ValId { get; set; }
        public float? ValTaux { get; set; }
        public DateTime? ValDateapplication { get; set; }
        public int? ValPerId { get; set; }
        public int? ValAssId { get; set; }
        public int? ValTaxId { get; set; }
        public bool? ValBValide { get; set; }

        public virtual TResTaxassiete ValAss { get; set; }
        public virtual TResTaxperiodicite ValPer { get; set; }
        public virtual TResTaxe ValTax { get; set; }
    }
}
