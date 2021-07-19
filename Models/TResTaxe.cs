using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResTaxe
    {
        public TResTaxe()
        {
            TResCollecte = new HashSet<TResCollecte>();
            TResTaxactiviteDefaut = new HashSet<TResTaxactiviteDefaut>();
            TResTaxvaleur = new HashSet<TResTaxvaleur>();
        }

        public int TaxId { get; set; }
        public string TaxLibelle { get; set; }
        public string TaxDescription { get; set; }
        public int? TaxCpteCode { get; set; }
        public bool? TaxBActif { get; set; }
        public int? TaxTaxfId { get; set; }

        public virtual TResTaxcompte TaxCpteCodeNavigation { get; set; }
        public virtual TResTaxeFamille TaxTaxf { get; set; }
        public virtual ICollection<TResCollecte> TResCollecte { get; set; }
        public virtual ICollection<TResTaxactiviteDefaut> TResTaxactiviteDefaut { get; set; }
        public virtual ICollection<TResTaxvaleur> TResTaxvaleur { get; set; }
    }
}
