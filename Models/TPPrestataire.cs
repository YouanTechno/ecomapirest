using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPPrestataire
    {
        public TPPrestataire()
        {
            TPEtapeProjet = new HashSet<TPEtapeProjet>();
            TPPhaseProjet = new HashSet<TPPhaseProjet>();
        }

        public int PrestId { get; set; }
        public string PrestNom { get; set; }
        public string PrestContact { get; set; }
        public string PrestSiege { get; set; }

        public virtual ICollection<TPEtapeProjet> TPEtapeProjet { get; set; }
        public virtual ICollection<TPPhaseProjet> TPPhaseProjet { get; set; }
    }
}
