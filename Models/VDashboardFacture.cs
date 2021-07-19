using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VDashboardFacture
    {
        public int DashRecetteId { get; set; }
        public int ZoneId { get; set; }
        public DateTime? DashRecetteDate { get; set; }
        public float? DashRecettePrevision { get; set; }
        public float? DashRecetteRecette { get; set; }
        public float? DashRecetteRetard { get; set; }
        public int? CommuneId { get; set; }
        public int? QuartierId { get; set; }
        public int? IlotId { get; set; }
        public int? LotId { get; set; }
        public string CommuneLibelle { get; set; }
        public string QuartierLibelle { get; set; }
        public string IlotLibelle { get; set; }
        public string LotLibelle { get; set; }
        public string ZoneLibelle { get; set; }
    }
}
