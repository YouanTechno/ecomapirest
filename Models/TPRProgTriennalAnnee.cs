using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPRProgTriennalAnnee
    {
        public int ProgAnId { get; set; }
        public int? ProgAnAnneeId { get; set; }
        public int? ProgAnProgId { get; set; }

        public virtual TPAnnee ProgAnAnnee { get; set; }
        public virtual TPProgrammeTriennal ProgAnProg { get; set; }
    }
}
