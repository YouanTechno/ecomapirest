using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSCamera
    {
        public int CamId { get; set; }
        public string CamLibelle { get; set; }
        public string CamAdresse { get; set; }
        public bool? CamBFonctionel { get; set; }
        public DateTime? CamDateMiseEnService { get; set; }
        public string CamDescription { get; set; }
        public int? CamZoneId { get; set; }

        public virtual TZone CamZone { get; set; }
    }
}
