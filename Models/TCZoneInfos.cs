using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TCZoneInfos
    {
        public TCZoneInfos()
        {
            TCBatiment = new HashSet<TCBatiment>();
            TEspacemarche = new HashSet<TEspacemarche>();
            TRCZoneInfoProprietaireEntreprise = new HashSet<TRCZoneInfoProprietaireEntreprise>();
            TRCZoneInfoProprietaireOrdinaire = new HashSet<TRCZoneInfoProprietaireOrdinaire>();
            TZoneinfoZonepropriete = new HashSet<TZoneinfoZonepropriete>();
        }

        public int ZiId { get; set; }
        public int? ZiZoneId { get; set; }
        public string ZiSection { get; set; }
        public string ZiParcelle { get; set; }
        public string ZiIlot { get; set; }
        public string ZiLot { get; set; }
        public bool ZiBEau { get; set; }
        public bool ZiBElec { get; set; }
        public string ZiNatureCode { get; set; }
        public bool? BDelete { get; set; }

        public virtual TCNatureOccupation ZiNatureCodeNavigation { get; set; }
        public virtual TZone ZiZone { get; set; }
        public virtual ICollection<TCBatiment> TCBatiment { get; set; }
        public virtual ICollection<TEspacemarche> TEspacemarche { get; set; }
        public virtual ICollection<TRCZoneInfoProprietaireEntreprise> TRCZoneInfoProprietaireEntreprise { get; set; }
        public virtual ICollection<TRCZoneInfoProprietaireOrdinaire> TRCZoneInfoProprietaireOrdinaire { get; set; }
        public virtual ICollection<TZoneinfoZonepropriete> TZoneinfoZonepropriete { get; set; }
    }
}
