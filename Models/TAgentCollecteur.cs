using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TAgentCollecteur
    {
        public TAgentCollecteur()
        {
            TResCollecte = new HashSet<TResCollecte>();
        }

        public int AcolId { get; set; }
        public string AcolMatricule { get; set; }
        public string AcolNom { get; set; }
        public string AcolPrenom { get; set; }
        public bool? AcolBActif { get; set; }
        public int? AcolAgId { get; set; }
        public DateTime? AcolDate { get; set; }
        public string AcolSecteur { get; set; }
        public int? AcolSecteurZoneId { get; set; }

        public virtual TAgent AcolAg { get; set; }
        public virtual ICollection<TResCollecte> TResCollecte { get; set; }
    }
}
