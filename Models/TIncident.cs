using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TIncident
    {
        public int IncId { get; set; }
        public int? AgId { get; set; }
        public int? ModId { get; set; }
        public DateTime? IncDate { get; set; }
        public string IncDescription { get; set; }
        public string IncBEstBloquant { get; set; }

        public virtual TAgent Ag { get; set; }
        public virtual TModule Mod { get; set; }
    }
}
