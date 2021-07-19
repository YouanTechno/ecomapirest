using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResMetafacture
    {
        public TResMetafacture()
        {
            TResRFactureMetafacture = new HashSet<TResRFactureMetafacture>();
        }

        public int MefaId { get; set; }
        public string MefaCode { get; set; }
        public DateTime? MefaDate { get; set; }
        public int? MefaAgId { get; set; }

        public virtual TAgent MefaAg { get; set; }
        public virtual ICollection<TResRFactureMetafacture> TResRFactureMetafacture { get; set; }
    }
}
