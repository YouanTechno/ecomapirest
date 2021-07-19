using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VContraventionValeur
    {
        public int? ScValValeur { get; set; }
        public string ScContLibelle { get; set; }
        public string ScCatLibelle { get; set; }
        public string ScScatLibelle { get; set; }
        public DateTime? ScValDateEmission { get; set; }
        public string Libelle { get; set; }
        public int ZoneId { get; set; }
        public int ScValId { get; set; }
        public int ScContId { get; set; }
        public int ScScatId { get; set; }
        public int ScCatId { get; set; }
    }
}
