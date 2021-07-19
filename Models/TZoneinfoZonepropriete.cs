using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TZoneinfoZonepropriete
    {
        public int ZiprozId { get; set; }
        public int? ZiprozProzId { get; set; }
        public int? ZiprozZiId { get; set; }
        public string ZiprozValeur { get; set; }
        public int? ZiprozEntier { get; set; }
        public DateTime? ZiprozDate { get; set; }
        public bool? ZiprozBooleen { get; set; }

        public virtual TZonePropriete ZiprozProz { get; set; }
        public virtual TCZoneInfos ZiprozZi { get; set; }
    }
}
