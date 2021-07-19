using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VResRecette
    {
        public int PaieId { get; set; }
        public float? PaieMontant { get; set; }
        public DateTime? PaieDate { get; set; }
        public string Zone { get; set; }
        public string Libelle { get; set; }
        public int? ZoneId { get; set; }
        public int? CommuneId { get; set; }
        public int? QuartierId { get; set; }
        public int? IlotId { get; set; }
        public int? LotId { get; set; }
        public string CommuneLibelle { get; set; }
        public string QuartierLibelle { get; set; }
        public string IlotLibelle { get; set; }
        public string LotLibelle { get; set; }
        public string FactCode { get; set; }
        public string ScContLibelle { get; set; }
    }
}
