using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TZonePropriete
    {
        public TZonePropriete()
        {
            TZoneinfoZonepropriete = new HashSet<TZoneinfoZonepropriete>();
        }

        public int ProzId { get; set; }
        public string ProzLibelle { get; set; }
        public string ProzDescription { get; set; }

        public virtual ICollection<TZoneinfoZonepropriete> TZoneinfoZonepropriete { get; set; }
    }
}
