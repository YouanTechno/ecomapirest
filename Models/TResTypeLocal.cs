using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResTypeLocal
    {
        public TResTypeLocal()
        {
            TResReferencement = new HashSet<TResReferencement>();
        }

        public int TlId { get; set; }
        public string TlLibelle { get; set; }
        public string TlDescription { get; set; }
        public string TlLibelleNumerique { get; set; }
        public string TlLibelleAlpha { get; set; }
        public string TlCode { get; set; }

        public virtual ICollection<TResReferencement> TResReferencement { get; set; }
    }
}
