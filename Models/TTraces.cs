using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TTraces
    {
        public int TracId { get; set; }
        public int? AgId { get; set; }
        public DateTime TracDate { get; set; }
        public string TracObjetValeur { get; set; }
        public int? TracAction { get; set; }
        public string TracObjet { get; set; }
        public string TracDescription { get; set; }
        public bool TracBConnexion { get; set; }
        public bool TracBDeconnexion { get; set; }

        public virtual TAgent Ag { get; set; }
    }
}
