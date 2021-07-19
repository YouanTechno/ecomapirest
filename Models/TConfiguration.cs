using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TConfiguration
    {
        public int ConfId { get; set; }
        public int? ConfDecoupageCommune { get; set; }
        public int? ConfDecoupageCadastre { get; set; }
        public string ConfCommune { get; set; }
        public string ConfCommuneCode { get; set; }
        public int? ConfZoneCategorieCommune { get; set; }
        public int? ConfZoneCategorieQuartier { get; set; }
        public int? ConfZoneCategorieIlot { get; set; }
        public int? ConfZoneCategorieLot { get; set; }
        public string CofDevise { get; set; }
        public int? ConfMontantTp { get; set; }
        public DateTime? ConfDateDebutFacturationATraiter { get; set; }
        public byte[] ConfImageFond { get; set; }
        public string ConfTitreDiapoAcceuil { get; set; }
        public string ConfChaineConnexion { get; set; }
        public string ConfUrlImage { get; set; }
        public string ConfEtatFacture { get; set; }
        public string ConfEtatDash1 { get; set; }
        public string ConfEtatDash2 { get; set; }
        public string ConfAutre1 { get; set; }
        public string ConfAutre2 { get; set; }
        public string ConfAutre3 { get; set; }
        public string ConfAutre4 { get; set; }
        public string ConfAutre5 { get; set; }
        public string Wkid { get; set; }

        public virtual TZoneType ConfDecoupageCadastreNavigation { get; set; }
        public virtual TZoneType ConfDecoupageCommuneNavigation { get; set; }
    }
}
