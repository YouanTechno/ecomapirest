using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TREInfoEcheanceCentre
    {
        public int InfoId { get; set; }
        public decimal? InfoNbreVotant { get; set; }
        public decimal? InfoSufExp { get; set; }
        public decimal? InfoBulNul { get; set; }
        public int CentId { get; set; }
        public int? EchId { get; set; }

        public virtual TECentreElectoral Cent { get; set; }
        public virtual TEEcheanceElectoral Ech { get; set; }
    }
}
