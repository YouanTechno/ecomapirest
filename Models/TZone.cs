using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TZone
    {
        public TZone()
        {
            InverseIdZoneParentNavigation = new HashSet<TZone>();
            TCZoneInfos = new HashSet<TCZoneInfos>();
            TDashboardRecettePaiement = new HashSet<TDashboardRecettePaiement>();
            TECentreElectoral = new HashSet<TECentreElectoral>();
            TPRProjetZone = new HashSet<TPRProjetZone>();
            TResActivitecontribuable = new HashSet<TResActivitecontribuable>();
            TResReferencement = new HashSet<TResReferencement>();
            TSCamera = new HashSet<TSCamera>();
            TSContValeur = new HashSet<TSContValeur>();
            TSIncIncident = new HashSet<TSIncIncident>();
            TValeurIndicateurZone = new HashSet<TValeurIndicateurZone>();
            TZoneCaracteristiquePresence = new HashSet<TZoneCaracteristiquePresence>();
        }

        public int ZoneId { get; set; }
        public int? IdZoneParent { get; set; }
        public int? IdCat { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public float? SpgeGpsLon { get; set; }
        public float? SpgeGpsLat { get; set; }
        public int? SpgeRepere { get; set; }
        public string CodGeo { get; set; }
        public string CodGeoParent { get; set; }
        public int? NumCntig { get; set; }
        public int? ZoneSecId { get; set; }
        public bool? BDelete { get; set; }

        public virtual TZoneCategorie IdCatNavigation { get; set; }
        public virtual TZone IdZoneParentNavigation { get; set; }
        public virtual TZoneSecteur ZoneSec { get; set; }
        public virtual ICollection<TZone> InverseIdZoneParentNavigation { get; set; }
        public virtual ICollection<TCZoneInfos> TCZoneInfos { get; set; }
        public virtual ICollection<TDashboardRecettePaiement> TDashboardRecettePaiement { get; set; }
        public virtual ICollection<TECentreElectoral> TECentreElectoral { get; set; }
        public virtual ICollection<TPRProjetZone> TPRProjetZone { get; set; }
        public virtual ICollection<TResActivitecontribuable> TResActivitecontribuable { get; set; }
        public virtual ICollection<TResReferencement> TResReferencement { get; set; }
        public virtual ICollection<TSCamera> TSCamera { get; set; }
        public virtual ICollection<TSContValeur> TSContValeur { get; set; }
        public virtual ICollection<TSIncIncident> TSIncIncident { get; set; }
        public virtual ICollection<TValeurIndicateurZone> TValeurIndicateurZone { get; set; }
        public virtual ICollection<TZoneCaracteristiquePresence> TZoneCaracteristiquePresence { get; set; }
    }
}
