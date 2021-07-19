using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VZone
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
        public string CodGeoCommune { get; set; }
        public int? NumCntigCommune { get; set; }
        public string CodGeoIlot { get; set; }
        public int? NumCntigIlo { get; set; }
        public string CodGeoLot { get; set; }
        public int? NumCntigLot { get; set; }
        public string CodGeoQuartier { get; set; }
        public int? NumCntigQuartier { get; set; }
    }
}
