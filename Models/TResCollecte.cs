using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResCollecte
    {
        public TResCollecte()
        {
            TResPaiement = new HashSet<TResPaiement>();
        }

        public int ColId { get; set; }
        public int ColActcontId { get; set; }
        public int ColTaxId { get; set; }
        public float ColMontant { get; set; }
        public DateTime ColDate { get; set; }
        public bool ColBExportPaiement { get; set; }
        public int? ColAgId { get; set; }
        public int? ColAcolId { get; set; }
        public int ColFactId { get; set; }

        public virtual TAgentCollecteur ColAcol { get; set; }
        public virtual TAgent ColAg { get; set; }
        public virtual TResFacture ColFact { get; set; }
        public virtual TResTaxe ColTax { get; set; }
        public virtual ICollection<TResPaiement> TResPaiement { get; set; }
    }
}
