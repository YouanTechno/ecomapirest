using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPPhaseProjet
    {
        public TPPhaseProjet()
        {
            TPTache = new HashSet<TPTache>();
        }

        public int PhaseId { get; set; }
        public string PhaseIntitule { get; set; }
        public DateTime? PhaseDateDebut { get; set; }
        public DateTime? PhaseDateFin { get; set; }
        public string PhaseDesc { get; set; }
        public float? PhaseCout { get; set; }
        public int? PhasePrestId { get; set; }
        public int? PhaseProjId { get; set; }

        public virtual TPPrestataire PhasePrest { get; set; }
        public virtual TPProjet PhaseProj { get; set; }
        public virtual ICollection<TPTache> TPTache { get; set; }
    }
}
