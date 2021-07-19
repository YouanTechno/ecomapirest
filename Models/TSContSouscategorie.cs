using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSContSouscategorie
    {
        public TSContSouscategorie()
        {
            TSContContravention = new HashSet<TSContContravention>();
        }

        public int ScScatId { get; set; }
        public string ScScatLibelle { get; set; }
        public string ScScatDescription { get; set; }
        public int? ScScatScCatId { get; set; }

        public virtual TSContCategorie ScScatScCat { get; set; }
        public virtual ICollection<TSContContravention> TSContContravention { get; set; }
    }
}
