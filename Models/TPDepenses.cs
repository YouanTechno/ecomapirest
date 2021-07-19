using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPDepenses
    {
        public int DepId { get; set; }
        public float? DepAnterieur { get; set; }
        public float? DepPosterieur { get; set; }
        public int? DepProgprojId { get; set; }

        public virtual TPRProgrammeProjet DepProgproj { get; set; }
    }
}
