using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSContContravention
    {
        public TSContContravention()
        {
            TSContMontant = new HashSet<TSContMontant>();
            TSContValeur = new HashSet<TSContValeur>();
        }

        public int ScContId { get; set; }
        public string ScContLibelle { get; set; }
        public string ScContDescription { get; set; }
        public int? ScContScScatId { get; set; }

        public virtual TSContSouscategorie ScContScScat { get; set; }
        public virtual ICollection<TSContMontant> TSContMontant { get; set; }
        public virtual ICollection<TSContValeur> TSContValeur { get; set; }
    }
}
