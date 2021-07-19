using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResTypeActivite
    {
        public TResTypeActivite()
        {
            TResEspaceExploitable = new HashSet<TResEspaceExploitable>();
            TResReferencement = new HashSet<TResReferencement>();
        }

        public int TaId { get; set; }
        public string TaLibelle { get; set; }
        public string TaDescription { get; set; }
        public string TaCode { get; set; }

        public virtual ICollection<TResEspaceExploitable> TResEspaceExploitable { get; set; }
        public virtual ICollection<TResReferencement> TResReferencement { get; set; }
    }
}
