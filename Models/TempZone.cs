using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TempZone
    {
        public int Id { get; set; }
        public string CodGeo { get; set; }
        public string Quartier { get; set; }
        public string Ilot { get; set; }
        public string Lot { get; set; }
        public string Cntig { get; set; }
    }
}
