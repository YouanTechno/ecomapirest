using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TCProprietaireEntreprise
    {
        public TCProprietaireEntreprise()
        {
            TRCZoneInfoProprietaireEntreprise = new HashSet<TRCZoneInfoProprietaireEntreprise>();
        }

        public int PeId { get; set; }
        public string PeRaisonSociale { get; set; }
        public string PeAddressePostale { get; set; }
        public string PeNcc { get; set; }
        public string PeTel { get; set; }
        public string PeFax { get; set; }

        public virtual ICollection<TRCZoneInfoProprietaireEntreprise> TRCZoneInfoProprietaireEntreprise { get; set; }
    }
}
