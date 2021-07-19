using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TRCZoneInfoProprietaireEntreprise
    {
        public int ZpeId { get; set; }
        public int ZpePeId { get; set; }
        public int ZpeZiId { get; set; }
        public DateTime? ZpeDate { get; set; }
        public string ZpeTf { get; set; }
        public string ZpeCfCode { get; set; }

        public virtual TCConservationFonciere ZpeCfCodeNavigation { get; set; }
        public virtual TCProprietaireEntreprise ZpePe { get; set; }
        public virtual TCZoneInfos ZpeZi { get; set; }
    }
}
