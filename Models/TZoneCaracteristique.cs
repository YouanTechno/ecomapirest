using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TZoneCaracteristique
    {
        public TZoneCaracteristique()
        {
            TZoneCaracteristiquePresence = new HashSet<TZoneCaracteristiquePresence>();
        }

        public int ZcId { get; set; }
        public string ZcLibelle { get; set; }
        public string ZcDescription { get; set; }

        public virtual ICollection<TZoneCaracteristiquePresence> TZoneCaracteristiquePresence { get; set; }
    }
}
