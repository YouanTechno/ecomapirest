using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSContMontant
    {
        public int ScMonId { get; set; }
        public int? ScMonValeur { get; set; }
        public DateTime? ScMonDate { get; set; }
        public int? ScMonContId { get; set; }

        public virtual TSContContravention ScMonCont { get; set; }
    }
}
