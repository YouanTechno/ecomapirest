using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPAnnee
    {
        public TPAnnee()
        {
            TPRProgTriennalAnnee = new HashSet<TPRProgTriennalAnnee>();
            TPRProgrammeProjetAnnee = new HashSet<TPRProgrammeProjetAnnee>();
        }

        public int AnneeId { get; set; }
        public string AnneeLib { get; set; }

        public virtual ICollection<TPRProgTriennalAnnee> TPRProgTriennalAnnee { get; set; }
        public virtual ICollection<TPRProgrammeProjetAnnee> TPRProgrammeProjetAnnee { get; set; }
    }
}
