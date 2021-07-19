using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VRecouvrementCarte
    {
        public int ZoneId { get; set; }
        public int? NumCntig { get; set; }
        public string ActcontPlaqueOld { get; set; }
        public int? ZoneSecId { get; set; }
        public int? TaxTaxfId { get; set; }
        public int? ActcontActId { get; set; }
        public string CodGeo { get; set; }
        public int? NombreImpaye { get; set; }
        public double? MontantImpaye { get; set; }
        public string QuartierLibelle { get; set; }
    }
}
