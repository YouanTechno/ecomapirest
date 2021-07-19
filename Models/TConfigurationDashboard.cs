using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TConfigurationDashboard
    {
        public int ConfdashId { get; set; }
        public int? ConfdashIaHaut1 { get; set; }
        public int? ConfdashIaHaut2 { get; set; }
        public int? ConfdashIaHaut3 { get; set; }
        public int? ConfdashIaBas1 { get; set; }
        public int? ConfdashIaBas2 { get; set; }
        public int? ConfdashIaBas3 { get; set; }
    }
}
