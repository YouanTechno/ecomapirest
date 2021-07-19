using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VProjetparquatier
    {
        public int ProjId { get; set; }
        public string ProjLibelle { get; set; }
        public float? ProjCout { get; set; }
        public DateTime? ProjDateDebut { get; set; }
        public DateTime? ProjDateFin { get; set; }
        public string ProjDescription { get; set; }
        public string ProjIndicateur { get; set; }
        public int? ProjEtatRealisation { get; set; }
        public int? ProjMouId { get; set; }
        public int? ProjMoeId { get; set; }
        public int? ProjZoneId { get; set; }
        public int? ProjCatId { get; set; }
        public bool? ProjBMarche { get; set; }
        public bool? ProjBTp { get; set; }
        public string Libelle { get; set; }
    }
}
