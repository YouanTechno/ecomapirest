using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResTaxeFamille
    {
        public TResTaxeFamille()
        {
            TResTaxe = new HashSet<TResTaxe>();
        }

        public int TaxfId { get; set; }
        public string TaxfLibelle { get; set; }
        public string TaxfDescription { get; set; }
        public string TaxfUrlImage { get; set; }

        public virtual ICollection<TResTaxe> TResTaxe { get; set; }
    }
}
