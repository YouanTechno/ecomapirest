using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResTaxassiete
    {
        public TResTaxassiete()
        {
            TResTaxvaleur = new HashSet<TResTaxvaleur>();
        }

        public int AssId { get; set; }
        public string AssLibelle { get; set; }
        public string AssDescription { get; set; }

        public virtual ICollection<TResTaxvaleur> TResTaxvaleur { get; set; }
    }
}
