using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VProgrammeProjetAnnee
    {
        public int AnneeId { get; set; }
        public string AnneeLib { get; set; }
        public int ProgAnId { get; set; }
        public int? ProgAnAnneeId { get; set; }
        public int? ProgAnProgId { get; set; }
        public int ProgprojId { get; set; }
        public int? ProgprojProjId { get; set; }
        public int? ProgprojProgId { get; set; }
        public int? ProgprojNumordre { get; set; }
        public int ProgId { get; set; }
        public string ProgLibelle { get; set; }
        public string ProgDescription { get; set; }
        public DateTime? ProgDatedebut { get; set; }
        public DateTime? ProgDatefin { get; set; }
    }
}
