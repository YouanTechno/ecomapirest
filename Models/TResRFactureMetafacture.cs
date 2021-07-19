using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResRFactureMetafacture
    {
        public int FacmetafactId { get; set; }
        public int? FactmetafactFactId { get; set; }
        public int? FactmetafactMefaId { get; set; }

        public virtual TResFacture FactmetafactFact { get; set; }
        public virtual TResMetafacture FactmetafactMefa { get; set; }
    }
}
