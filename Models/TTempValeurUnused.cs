using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TTempValeurUnused
    {
        public int ValZoneId { get; set; }
        public string ValZoneLibelle { get; set; }
        public string ValZoneLibelleComplet { get; set; }
        public float? ValMontant { get; set; }
    }
}
