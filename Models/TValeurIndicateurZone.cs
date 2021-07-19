using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TValeurIndicateurZone
    {
        public int ValId { get; set; }
        public string IndCode { get; set; }
        public int? ZoneId { get; set; }
        public float? ValValeurNumerique { get; set; }
        public string ValValeurAlpha { get; set; }
        public DateTime ValDate { get; set; }

        public virtual TIndicateur IndCodeNavigation { get; set; }
        public virtual TZone Zone { get; set; }
    }
}
