using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TEEcheanceElectoral
    {
        public TEEcheanceElectoral()
        {
            TECandidat = new HashSet<TECandidat>();
            TEIncident = new HashSet<TEIncident>();
            TREInfoEcheanceCentre = new HashSet<TREInfoEcheanceCentre>();
        }

        public int EchId { get; set; }
        public string EchLibelle { get; set; }
        public string EchDate { get; set; }

        public virtual ICollection<TECandidat> TECandidat { get; set; }
        public virtual ICollection<TEIncident> TEIncident { get; set; }
        public virtual ICollection<TREInfoEcheanceCentre> TREInfoEcheanceCentre { get; set; }
    }
}
