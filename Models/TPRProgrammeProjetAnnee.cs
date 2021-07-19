using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPRProgrammeProjetAnnee
    {
        public int ProgProjAnId { get; set; }
        public int? ProgProjAnAnneeId { get; set; }
        public int? ProgProjAnProgprojId { get; set; }
        public float? ProgProjAnMontant { get; set; }
        public float? ProgProjAnDepenseant { get; set; }
        public float? ProgProjAnDepensepost { get; set; }

        public virtual TPAnnee ProgProjAnAnnee { get; set; }
        public virtual TPRProgrammeProjet ProgProjAnProgproj { get; set; }
    }
}
