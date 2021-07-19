using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TZoneCategorie
    {
        public TZoneCategorie()
        {
            TZone = new HashSet<TZone>();
        }

        public int IdCat { get; set; }
        public int? CodParent { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string UrlCouche { get; set; }
        public int? IdTypezone { get; set; }
        public int? CatZoneOrdre { get; set; }
        public bool? CatZoneEstActif { get; set; }
        public int? CatZoneEstParcelleSectionAutre { get; set; }

        public virtual TZoneType IdTypezoneNavigation { get; set; }
        public virtual ICollection<TZone> TZone { get; set; }
    }
}
