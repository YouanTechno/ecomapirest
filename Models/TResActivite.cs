using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResActivite
    {
        public TResActivite()
        {
            TActivite = new HashSet<TActivite>();
            TResActivitecontribuable = new HashSet<TResActivitecontribuable>();
            TResFacture = new HashSet<TResFacture>();
            TResTaxactiviteDefaut = new HashSet<TResTaxactiviteDefaut>();
        }

        public int ActId { get; set; }
        public string ActLibelle { get; set; }
        public string ActDescription { get; set; }
        public bool? ActBOdp { get; set; }
        public string ActCode { get; set; }
        public int? ActTaxeMoyenneMois { get; set; }
        public int? ActTaxeMoyenneJour { get; set; }
        public int? ActTaxeMoyenneAn { get; set; }

        public virtual ICollection<TActivite> TActivite { get; set; }
        public virtual ICollection<TResActivitecontribuable> TResActivitecontribuable { get; set; }
        public virtual ICollection<TResFacture> TResFacture { get; set; }
        public virtual ICollection<TResTaxactiviteDefaut> TResTaxactiviteDefaut { get; set; }
    }
}
