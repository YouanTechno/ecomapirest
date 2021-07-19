using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TEspacemarche
    {
        public TEspacemarche()
        {
            TActivite = new HashSet<TActivite>();
        }

        public int EspmarchId { get; set; }
        public int? EspmarchEsptypId { get; set; }
        public int? EspmarchNiveau { get; set; }
        public string EspmarchRangee { get; set; }
        public string EspmarchNummairie { get; set; }
        public string EspmarchLibelle { get; set; }
        public int? EspmarchMarchId { get; set; }
        public int? EspmarchZiId { get; set; }

        public virtual TEspaceType EspmarchEsptyp { get; set; }
        public virtual TMarche EspmarchMarch { get; set; }
        public virtual TCZoneInfos EspmarchZi { get; set; }
        public virtual ICollection<TActivite> TActivite { get; set; }
    }
}
