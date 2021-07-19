using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VResActiviteContribuable
    {
        public int ActcontId { get; set; }
        public bool? ActcontBOdp { get; set; }
        public int? ActcontContId { get; set; }
        public int? ActcontActId { get; set; }
        public int? ActcontZoneId { get; set; }
        public DateTime? ActcontDateIntroDemande { get; set; }
        public int? ActcontAgentIntroDemande { get; set; }
        public DateTime? ActconDatePriseDecision { get; set; }
        public int? ActconAgentDecision { get; set; }
        public bool? ActcontBDecisionMes { get; set; }
        public string ActcontNom { get; set; }
        public string ActcontPlaque { get; set; }
        public string ActcontPlaqueOld { get; set; }
        public int? ActcontRefId { get; set; }
        public DateTime? ActcontDateFermetureDemande { get; set; }
        public int? ActcontAgentFermetureDemande { get; set; }
        public string ActcontFermetureRaison { get; set; }
        public DateTime? ActontDateFermetureDecision { get; set; }
        public DateTime? ActontAgentFermetureDecision { get; set; }
        public bool? ActcontBDecisionFermeture { get; set; }
        public int? ActcontActiviteId { get; set; }
        public string RefValeur { get; set; }
        public float? RefNumerique { get; set; }
        public string RefAlpha { get; set; }
        public string RefDescription { get; set; }
        public int? RefTlId { get; set; }
        public int? RefTaId { get; set; }
        public int? RefEspId { get; set; }
        public int? RefZoneId { get; set; }
        public int? RefNumCntig { get; set; }
        public string RefNumMairie { get; set; }
        public int ContId { get; set; }
        public string ContNom { get; set; }
        public string ContPrenom { get; set; }
        public string ContNcc { get; set; }
        public string ContPieceCode { get; set; }
        public string ContNumPiece { get; set; }
        public string ContMatricule { get; set; }
        public DateTime? ContDateImmatriculation { get; set; }
        public string ContMatriculeAnnuel { get; set; }
        public DateTime? ContDateImmatriculationAnnuelle { get; set; }
        public string ContTelephone { get; set; }
        public string ContMail { get; set; }
        public int? TaId { get; set; }
        public string TaLibelle { get; set; }
        public string TaDescription { get; set; }
        public string TaCode { get; set; }
        public int ActId { get; set; }
        public string ActLibelle { get; set; }
        public string ActDescription { get; set; }
        public bool? ActBOdp { get; set; }
        public string ActCode { get; set; }
        public int? ActTaxeMoyenneMois { get; set; }
        public int? ActTaxeMoyenneJour { get; set; }
        public int? ActTaxeMoyenneAn { get; set; }
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
