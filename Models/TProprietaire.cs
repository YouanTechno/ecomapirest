using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TProprietaire
    {
        public TProprietaire()
        {
            TActivite = new HashSet<TActivite>();
            TReferencePropriete = new HashSet<TReferencePropriete>();
        }

        public int ProId { get; set; }
        public string ProNom { get; set; }
        public string ProPrenom { get; set; }
        public bool? ProGenreMasculin { get; set; }
        public int? ProNationId { get; set; }
        public int? ProPieceNatureId { get; set; }
        public string ProPieceNumero { get; set; }

        public virtual TNationalite ProNation { get; set; }
        public virtual TTypePiece ProPieceNature { get; set; }
        public virtual ICollection<TActivite> TActivite { get; set; }
        public virtual ICollection<TReferencePropriete> TReferencePropriete { get; set; }
    }
}
