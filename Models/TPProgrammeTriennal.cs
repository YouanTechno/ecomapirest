using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPProgrammeTriennal
    {
        public TPProgrammeTriennal()
        {
            TPRProgTriennalAnnee = new HashSet<TPRProgTriennalAnnee>();
            TPRProgrammeProjet = new HashSet<TPRProgrammeProjet>();
        }

        public int ProgId { get; set; }
        public string ProgLibelle { get; set; }
        public string ProgDescription { get; set; }
        public DateTime? ProgDatedebut { get; set; }
        public DateTime? ProgDatefin { get; set; }

        public virtual ICollection<TPRProgTriennalAnnee> TPRProgTriennalAnnee { get; set; }
        public virtual ICollection<TPRProgrammeProjet> TPRProgrammeProjet { get; set; }
    }
}
