using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSIncIncident
    {
        public int SiIncId { get; set; }
        public string SiIncLibelle { get; set; }
        public DateTime? SiIncDate { get; set; }
        public string SiIncDescripLieu { get; set; }
        public string SiIncDescription { get; set; }
        public double? SiIncLon { get; set; }
        public double? SiIncLat { get; set; }
        public int? SiIncWkid { get; set; }
        public int? SiIncZoneId { get; set; }
        public string SiIncZoneCodeGeo { get; set; }
        public int? SiCatSiIncId { get; set; }

        public virtual TSIncCategorie SiCatSiInc { get; set; }
        public virtual TZone SiIncZone { get; set; }
    }
}
