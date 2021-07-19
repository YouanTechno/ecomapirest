using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPotentiel
    {
        public int PotId { get; set; }
        public string PotQuartier { get; set; }
        public int? PotPotentiel { get; set; }
        public int? PotAnnee { get; set; }
    }
}
