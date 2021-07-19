using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TNationalite
    {
        public TNationalite()
        {
            TProprietaire = new HashSet<TProprietaire>();
        }

        public int NatId { get; set; }
        public string NatLibelle { get; set; }

        public virtual ICollection<TProprietaire> TProprietaire { get; set; }
    }
}
