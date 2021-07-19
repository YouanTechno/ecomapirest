using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TRCBatimentContribuable
    {
        public int AbcId { get; set; }
        public int? AbcContId { get; set; }
        public int? AbcBatId { get; set; }
        public DateTime? AbcDate { get; set; }
        public DateTime? AbcDateFin { get; set; }

        public virtual TCBatiment AbcBat { get; set; }
        public virtual TCContribuable AbcCont { get; set; }
    }
}
