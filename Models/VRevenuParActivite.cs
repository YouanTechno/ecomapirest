using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VRevenuParActivite
    {
        public int TaId { get; set; }
        public int ActId { get; set; }
        public string TaCode { get; set; }
        public string TaLibelle { get; set; }
        public int EspId { get; set; }
        public string EspLibelle { get; set; }
        public string ActLibelle { get; set; }
        public int? Nombre { get; set; }
        public double? Montant { get; set; }
        public int? Officiel { get; set; }
        public int? Annee { get; set; }
    }
}
