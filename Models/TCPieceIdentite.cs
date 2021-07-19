using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TCPieceIdentite
    {
        public TCPieceIdentite()
        {
            TCContribuable = new HashSet<TCContribuable>();
            TCProprietaireOrdinaire = new HashSet<TCProprietaireOrdinaire>();
        }

        public string PieceCode { get; set; }
        public string PieceLibelle { get; set; }

        public virtual ICollection<TCContribuable> TCContribuable { get; set; }
        public virtual ICollection<TCProprietaireOrdinaire> TCProprietaireOrdinaire { get; set; }
    }
}
