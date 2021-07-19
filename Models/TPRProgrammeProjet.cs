using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPRProgrammeProjet
    {
        public TPRProgrammeProjet()
        {
            TPDepenses = new HashSet<TPDepenses>();
            TPRProgrammeProjetAnnee = new HashSet<TPRProgrammeProjetAnnee>();
        }

        public int ProgprojId { get; set; }
        public int? ProgprojProjId { get; set; }
        public int? ProgprojProgId { get; set; }
        public int? ProgprojNumordre { get; set; }

        public virtual TPProgrammeTriennal ProgprojProg { get; set; }
        public virtual TPProjet ProgprojProj { get; set; }
        public virtual ICollection<TPDepenses> TPDepenses { get; set; }
        public virtual ICollection<TPRProgrammeProjetAnnee> TPRProgrammeProjetAnnee { get; set; }
    }
}
