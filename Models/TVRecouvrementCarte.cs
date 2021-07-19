using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TVRecouvrementCarte
    {
        public int Id { get; set; }
        public int? ZoneId { get; set; }
        public string NumCntig { get; set; }
        public string ActcontPlaqueOld { get; set; }
        public int? ZoneSecId { get; set; }
        public int? TaxTaxfId { get; set; }
        public int? ActcontActId { get; set; }
        public string CodGeo { get; set; }
        public int? NombreImpaye { get; set; }
        public int? MontantImpaye { get; set; }
        public string QuartierLibelle { get; set; }
    }
}
