using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VComplementaire
    {
        public int Id { get; set; }
        public string Commune { get; set; }
        public int? Nombre { get; set; }
        public int? Eau { get; set; }
        public int? Electricite { get; set; }
        public int? Batiments { get; set; }
        public int? NombreParcelleBati { get; set; }
        public int? NombreParcelleNonBati { get; set; }
    }
}
