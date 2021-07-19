using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResActivitecontribuable
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

        public virtual TResActivite ActcontAct { get; set; }
        public virtual TCContribuable ActcontCont { get; set; }
        public virtual TZone ActcontZone { get; set; }
    }
}
