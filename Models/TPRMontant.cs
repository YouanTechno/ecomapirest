using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPRMontant
    {
        public int MontId { get; set; }
        public int? MontBaiId { get; set; }
        public int? MontProjId { get; set; }
        public float? MontSomme { get; set; }

        public virtual TPBailleur MontBai { get; set; }
        public virtual TPProjet MontProj { get; set; }
    }
}
