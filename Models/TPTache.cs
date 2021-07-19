using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPTache
    {
        public TPTache()
        {
            TPTacheRealiser = new HashSet<TPTacheRealiser>();
        }

        public int TacheId { get; set; }
        public string TacheLibelle { get; set; }
        public string TacheDesc { get; set; }
        public int? TachePhaseId { get; set; }
        public int? TacheEtat { get; set; }

        public virtual TPPhaseProjet TachePhase { get; set; }
        public virtual ICollection<TPTacheRealiser> TPTacheRealiser { get; set; }
    }
}
