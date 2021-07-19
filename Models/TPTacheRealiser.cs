using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPTacheRealiser
    {
        public int TacheRealId { get; set; }
        public int? TacheRealTacheId { get; set; }
        public string TacheRealAppreciation { get; set; }
        public float? TacheRealPourcentage { get; set; }

        public virtual TPTache TacheRealTache { get; set; }
    }
}
