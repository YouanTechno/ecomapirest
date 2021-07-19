using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TECentreElectoral
    {
        public TECentreElectoral()
        {
            TEIncident = new HashSet<TEIncident>();
            TREInfoEcheanceCentre = new HashSet<TREInfoEcheanceCentre>();
            TREResulatObtenuCentre = new HashSet<TREResulatObtenuCentre>();
        }

        public int CentId { get; set; }
        public string CentLibelle { get; set; }
        public int ZoneId { get; set; }
        public string Description { get; set; }

        public virtual TZone Zone { get; set; }
        public virtual ICollection<TEIncident> TEIncident { get; set; }
        public virtual ICollection<TREInfoEcheanceCentre> TREInfoEcheanceCentre { get; set; }
        public virtual ICollection<TREResulatObtenuCentre> TREResulatObtenuCentre { get; set; }
    }
}
