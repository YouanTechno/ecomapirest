using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSContValeur
    {
        public TSContValeur()
        {
            TResPaiement = new HashSet<TResPaiement>();
        }

        public int ScValId { get; set; }
        public int? ScValScContId { get; set; }
        public int? ScValZoneId { get; set; }
        public DateTime? ScValDateEmission { get; set; }
        public DateTime? ScValDateDelai { get; set; }
        public DateTime? ScValDatePaiement { get; set; }
        public int? ScValValeur { get; set; }
        public string ScValDescription { get; set; }
        public string ScValNomVictime { get; set; }
        public string ScValPrenomsVictime { get; set; }
        public string ScValDescriptionVictime { get; set; }

        public virtual TSContContravention ScValScCont { get; set; }
        public virtual TZone ScValZone { get; set; }
        public virtual ICollection<TResPaiement> TResPaiement { get; set; }
    }
}
