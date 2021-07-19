using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TCProprietaireOrdinaire
    {
        public TCProprietaireOrdinaire()
        {
            TRCZoneInfoProprietaireOrdinaire = new HashSet<TRCZoneInfoProprietaireOrdinaire>();
        }

        public int PoId { get; set; }
        public string PoNom { get; set; }
        public string PoPrenom { get; set; }
        public string PoPieceCode { get; set; }
        public string PoNumPiece { get; set; }
        public DateTime? PoDateDelivrance { get; set; }
        public DateTime? PoDateExpiration { get; set; }
        public string PoLieuDelivrance { get; set; }

        public virtual TCPieceIdentite PoPieceCodeNavigation { get; set; }
        public virtual ICollection<TRCZoneInfoProprietaireOrdinaire> TRCZoneInfoProprietaireOrdinaire { get; set; }
    }
}
