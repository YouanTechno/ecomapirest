using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TCContribuable
    {
        public TCContribuable()
        {
            TActivite = new HashSet<TActivite>();
            TRCBatimentContribuable = new HashSet<TRCBatimentContribuable>();
            TResActivitecontribuable = new HashSet<TResActivitecontribuable>();
            TResFacture = new HashSet<TResFacture>();
        }

        public int ContId { get; set; }
        public string ContNom { get; set; }
        public string ContPrenom { get; set; }
        public string ContNcc { get; set; }
        public string ContPieceCode { get; set; }
        public string ContNumPiece { get; set; }
        public string ContMatricule { get; set; }
        public DateTime? ContDateImmatriculation { get; set; }
        public string ContMatriculeAnnuel { get; set; }
        public DateTime? ContDateImmatriculationAnnuelle { get; set; }
        public string ContTelephone { get; set; }
        public string ContMail { get; set; }
        public int? ContNatId { get; set; }
        public DateTime? ContDateCreation { get; set; }

        public virtual TCPieceIdentite ContPieceCodeNavigation { get; set; }
        public virtual ICollection<TActivite> TActivite { get; set; }
        public virtual ICollection<TRCBatimentContribuable> TRCBatimentContribuable { get; set; }
        public virtual ICollection<TResActivitecontribuable> TResActivitecontribuable { get; set; }
        public virtual ICollection<TResFacture> TResFacture { get; set; }
    }
}
