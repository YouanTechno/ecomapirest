using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPRProjetZone
    {
        public int ProzoneId { get; set; }
        public int? ProzoneProjId { get; set; }
        public int? ProzoneZoneId { get; set; }

        public virtual TZone ProzoneZone { get; set; }
    }
}
