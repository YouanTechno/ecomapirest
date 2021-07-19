using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResAvoir
    {
        public int AvoirId { get; set; }
        public int AvoirContId { get; set; }
        public float AvoirMontant { get; set; }
        public int? AvoirFactId { get; set; }
    }
}
