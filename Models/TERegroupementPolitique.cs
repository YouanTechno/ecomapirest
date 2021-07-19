using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TERegroupementPolitique
    {
        public TERegroupementPolitique()
        {
            TECandidat = new HashSet<TECandidat>();
        }

        public int PartId { get; set; }
        public string PartLibelle { get; set; }
        public string PartSigle { get; set; }
        public byte[] PartEmbleme { get; set; }
        public string PartAdrPost { get; set; }

        public virtual ICollection<TECandidat> TECandidat { get; set; }
    }
}
