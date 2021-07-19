using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSIncCategorie
    {
        public TSIncCategorie()
        {
            TSIncIncident = new HashSet<TSIncIncident>();
        }

        public int SiCatId { get; set; }
        public string SiCatLibelle { get; set; }
        public string SiCatDesription { get; set; }
        public int? SiCatSiRepId { get; set; }
        public int? SiIncSiRepId { get; set; }

        public virtual TSIncRepresentation SiIncSiRep { get; set; }
        public virtual ICollection<TSIncIncident> TSIncIncident { get; set; }
    }
}
