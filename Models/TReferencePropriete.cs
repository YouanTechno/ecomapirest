using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TReferencePropriete
    {
        public int RefpId { get; set; }
        public int? RefpProId { get; set; }
        public int? RefpRefId { get; set; }
        public DateTime? RespDate { get; set; }

        public virtual TProprietaire RefpPro { get; set; }
        public virtual TResReferencement RefpRef { get; set; }
    }
}
