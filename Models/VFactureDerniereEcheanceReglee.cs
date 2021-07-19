using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VFactureDerniereEcheanceReglee
    {
        public int FactTaxactId { get; set; }
        public DateTime? FactDerniereEcheance { get; set; }
    }
}
