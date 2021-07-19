using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TTypePiece
    {
        public TTypePiece()
        {
            TProprietaire = new HashSet<TProprietaire>();
        }

        public int TpId { get; set; }
        public string TpLibelle { get; set; }
        public string PieceCode { get; set; }

        public virtual ICollection<TProprietaire> TProprietaire { get; set; }
    }
}
