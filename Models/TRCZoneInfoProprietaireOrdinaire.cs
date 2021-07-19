using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TRCZoneInfoProprietaireOrdinaire
    {
        public int ZpoId { get; set; }
        public int? ZpoPoId { get; set; }
        public int? ZpoZiId { get; set; }
        public DateTime? ZpoDate { get; set; }
        public string ZpoTf { get; set; }
        public string ZpoCfCode { get; set; }

        public virtual TCConservationFonciere ZpoCfCodeNavigation { get; set; }
        public virtual TCProprietaireOrdinaire ZpoPo { get; set; }
        public virtual TCZoneInfos ZpoZi { get; set; }
    }
}
