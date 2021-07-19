using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResTaxperiodicite
    {
        public TResTaxperiodicite()
        {
            TResTaxvaleur = new HashSet<TResTaxvaleur>();
        }

        public int PerId { get; set; }
        public string PerLibelle { get; set; }
        public bool? PerHeure { get; set; }
        public bool? PerJour { get; set; }
        public bool? PerMois { get; set; }
        public bool? PerAnnee { get; set; }
        public bool? PerUnique { get; set; }
        public int? PerValeur { get; set; }

        public virtual ICollection<TResTaxvaleur> TResTaxvaleur { get; set; }
    }
}
