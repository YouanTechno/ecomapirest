using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResTaxcompte
    {
        public TResTaxcompte()
        {
            InverseCpteIdparentNavigation = new HashSet<TResTaxcompte>();
            TResTaxe = new HashSet<TResTaxe>();
        }

        public int CpteCode { get; set; }
        public string CpteLibelle { get; set; }
        public string CpteDescription { get; set; }
        public bool? CpteBActif { get; set; }
        public int? CpteIdparent { get; set; }

        public virtual TResTaxcompte CpteIdparentNavigation { get; set; }
        public virtual ICollection<TResTaxcompte> InverseCpteIdparentNavigation { get; set; }
        public virtual ICollection<TResTaxe> TResTaxe { get; set; }
    }
}
