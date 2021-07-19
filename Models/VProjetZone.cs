using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VProjetZone
    {
        public int ZoneId { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public float? SpgeGpsLon { get; set; }
        public float? SpgeGpsLat { get; set; }
        public int? SpgeRepere { get; set; }
        public string CodGeo { get; set; }
        public int? NumCntig { get; set; }
        public int IdCat { get; set; }
        public string Categorie { get; set; }
        public int IdTypezone { get; set; }
        public string TypezoneLibelle { get; set; }
        public int? CommuneId { get; set; }
        public int? QuartierId { get; set; }
        public int? IlotId { get; set; }
        public int? LotId { get; set; }
        public string CommuneLibelle { get; set; }
        public string QuartierLibelle { get; set; }
        public string IlotLibelle { get; set; }
        public string LotLibelle { get; set; }
        public string ZoneLibelle { get; set; }
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
    }
}
