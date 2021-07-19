using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VRecettteMontant
    {
        public int Id { get; set; }
        public string Periodicite { get; set; }
        public double? Montant { get; set; }
    }
}
