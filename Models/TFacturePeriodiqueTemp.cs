using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TFacturePeriodiqueTemp
    {
        public int FacperId { get; set; }
        public int? FacperTaxactId { get; set; }
        public DateTime? FacperDebut { get; set; }
        public DateTime? FacperFin { get; set; }
        public float? FacperValeur { get; set; }
        public bool? FacperBExploite { get; set; }

        public virtual TResTaxeactivite FacperTaxact { get; set; }
    }
}
