using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TErreur
    {
        public int ErrId { get; set; }
        public int? AgId { get; set; }
        public string ErrObjet { get; set; }
        public string ErrProjet { get; set; }
        public string ErrMethode { get; set; }
        public string ErrMessage { get; set; }
        public string ErrPileAppel { get; set; }

        public virtual TAgent Err { get; set; }
    }
}
