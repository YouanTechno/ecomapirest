using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TCConservationFonciere
    {
        public TCConservationFonciere()
        {
            TRCZoneInfoProprietaireEntreprise = new HashSet<TRCZoneInfoProprietaireEntreprise>();
            TRCZoneInfoProprietaireOrdinaire = new HashSet<TRCZoneInfoProprietaireOrdinaire>();
        }

        public string CfCode { get; set; }
        public string CfLivreFoncier { get; set; }
        public string CfDescription { get; set; }

        public virtual ICollection<TRCZoneInfoProprietaireEntreprise> TRCZoneInfoProprietaireEntreprise { get; set; }
        public virtual ICollection<TRCZoneInfoProprietaireOrdinaire> TRCZoneInfoProprietaireOrdinaire { get; set; }
    }
}
