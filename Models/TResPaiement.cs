using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResPaiement
    {
        public int PaieId { get; set; }
        public int? PaieFactId { get; set; }
        public int? PaieFactAgId { get; set; }
        public float? PaieMontant { get; set; }
        public DateTime? PaieDate { get; set; }
        public int? PaieColId { get; set; }
        public int? PaieScValId { get; set; }

        public virtual TResCollecte PaieCol { get; set; }
        public virtual TResFacture PaieFact { get; set; }
        public virtual TSContValeur PaieScVal { get; set; }
    }
}
