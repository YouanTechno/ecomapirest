using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPProjet
    {
        public TPProjet()
        {
            TPEtapeProjet = new HashSet<TPEtapeProjet>();
            TPPhaseProjet = new HashSet<TPPhaseProjet>();
            TPRMontant = new HashSet<TPRMontant>();
            TPRProgrammeProjet = new HashSet<TPRProgrammeProjet>();
        }

        public int ProjId { get; set; }
        public string ProjLibelle { get; set; }
        public float? ProjCout { get; set; }
        public DateTime? ProjDateDebut { get; set; }
        public DateTime? ProjDateFin { get; set; }
        public string ProjDescription { get; set; }
        public string ProjIndicateur { get; set; }
        public int? ProjEtatRealisation { get; set; }
        public int? ProjMouId { get; set; }
        public int? ProjMoeId { get; set; }
        public int? ProjZoneId { get; set; }
        public int? ProjCatId { get; set; }
        public bool? ProjBMarche { get; set; }
        public bool? ProjBTp { get; set; }

        public virtual TPCategorie ProjCat { get; set; }
        public virtual TPMaitreOeuvre ProjMoe { get; set; }
        public virtual TPMaitreOuvrage ProjMou { get; set; }
        public virtual ICollection<TPEtapeProjet> TPEtapeProjet { get; set; }
        public virtual ICollection<TPPhaseProjet> TPPhaseProjet { get; set; }
        public virtual ICollection<TPRMontant> TPRMontant { get; set; }
        public virtual ICollection<TPRProgrammeProjet> TPRProgrammeProjet { get; set; }
    }
}
