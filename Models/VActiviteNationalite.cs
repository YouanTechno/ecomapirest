using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VActiviteNationalite
    {
        public string ActLibelle { get; set; }
        public string NatLibelle { get; set; }
        public int NatId { get; set; }
        public int ZoneId { get; set; }
        public int? QuartierId { get; set; }
        public string QuartierLibelle { get; set; }
        public int ActId { get; set; }
    }
}
