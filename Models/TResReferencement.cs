using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResReferencement
    {
        public TResReferencement()
        {
            TReferencePropriete = new HashSet<TReferencePropriete>();
        }

        public int RefId { get; set; }
        public string RefValeur { get; set; }
        public float? RefNumerique { get; set; }
        public string RefAlpha { get; set; }
        public string RefDescription { get; set; }
        public int? RefTlId { get; set; }
        public int? RefTaId { get; set; }
        public int? RefEspId { get; set; }
        public int? RefZoneId { get; set; }
        public int? RefNumCntig { get; set; }
        public string RefNumMairie { get; set; }

        public virtual TResEspaceExploitable RefEsp { get; set; }
        public virtual TResTypeActivite RefTa { get; set; }
        public virtual TResTypeLocal RefTl { get; set; }
        public virtual TZone RefZone { get; set; }
        public virtual ICollection<TReferencePropriete> TReferencePropriete { get; set; }
    }
}
