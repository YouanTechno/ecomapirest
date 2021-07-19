using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VZoneOccupationNombre
    {
        public int ZoneId { get; set; }
        public string ZoneLibelle { get; set; }
        public int? Nombre { get; set; }
    }
}
