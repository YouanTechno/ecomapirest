using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TZoneCaracteristiquePresence
    {
        public int ZcpId { get; set; }
        public int? ZcpZoneId { get; set; }
        public int? ZcpZcId { get; set; }
        public string ZcpCommentaire { get; set; }

        public virtual TZoneCaracteristique ZcpZc { get; set; }
        public virtual TZone ZcpZone { get; set; }
    }
}
