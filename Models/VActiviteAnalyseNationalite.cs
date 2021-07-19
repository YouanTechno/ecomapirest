using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VActiviteAnalyseNationalite
    {
        public DateTime? Annee { get; set; }
        public int? ActcontActId { get; set; }
        public string TaxfLibelle { get; set; }
        public int TaxfId { get; set; }
        public int NatId { get; set; }
        public int? Nombre { get; set; }
        public double? Somme { get; set; }
        public int? QuartierId { get; set; }
        public string QuartierLibelle { get; set; }
        public string NatLibelle { get; set; }
        public string ActcontNom { get; set; }
        public string ActLibelle { get; set; }
    }
}
