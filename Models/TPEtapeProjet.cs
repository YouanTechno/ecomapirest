using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPEtapeProjet
    {
        public int EtapeId { get; set; }
        public string EtapeIntitule { get; set; }
        public DateTime? EtapeDateDebut { get; set; }
        public DateTime? EtapeDateFin { get; set; }
        public string EtapeDesc { get; set; }
        public float? EtapeCout { get; set; }
        public int? EtapePrestId { get; set; }
        public int? EtapeProjId { get; set; }

        public virtual TPPrestataire EtapePrest { get; set; }
        public virtual TPProjet EtapeProj { get; set; }
    }
}
