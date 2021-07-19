using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TDashboardRecettePaiement
    {
        public int DashRecetteId { get; set; }
        public int? DashRecetteZoneId { get; set; }
        public DateTime? DashRecetteDate { get; set; }
        public float? DashRecettePrevision { get; set; }
        public float? DashRecetteRecette { get; set; }
        public float? DashRecetteRetard { get; set; }
        public int? DashRecetteCommuneId { get; set; }
        public int? DashRecetteQuartierId { get; set; }
        public int? DashRecetteIlotId { get; set; }
        public int? DashRecetteLotId { get; set; }

        public virtual TZone DashRecetteZone { get; set; }
    }
}
