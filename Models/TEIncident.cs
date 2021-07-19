using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TEIncident
    {
        public int IncId { get; set; }
        public string IncLibelle { get; set; }
        public string IncDescription { get; set; }
        public DateTime? IncDate { get; set; }
        public int? IncCentId { get; set; }
        public int IncEchId { get; set; }

        public virtual TECentreElectoral IncCent { get; set; }
        public virtual TEEcheanceElectoral IncEch { get; set; }
    }
}
