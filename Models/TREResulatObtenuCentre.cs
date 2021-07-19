using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TREResulatObtenuCentre
    {
        public int CcId { get; set; }
        public decimal? CcNbreVoix { get; set; }
        public int? CandId { get; set; }
        public int? CentId { get; set; }

        public virtual TECandidat Cand { get; set; }
        public virtual TECentreElectoral Cent { get; set; }
    }
}
