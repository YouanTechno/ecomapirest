using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TIaIndicateur
    {
        public TIaIndicateur()
        {
            TConfigurationSecuriteConfsecIaBasDroitNavigation = new HashSet<TConfigurationSecurite>();
            TConfigurationSecuriteConfsecIaHautDroitNavigation = new HashSet<TConfigurationSecurite>();
            TIaIndicateurAssocie = new HashSet<TIaIndicateurAssocie>();
        }

        public int IaId { get; set; }
        public string IaIndCode { get; set; }
        public string IaLibelle { get; set; }
        public int? IaNbMois { get; set; }

        public virtual ICollection<TConfigurationSecurite> TConfigurationSecuriteConfsecIaBasDroitNavigation { get; set; }
        public virtual ICollection<TConfigurationSecurite> TConfigurationSecuriteConfsecIaHautDroitNavigation { get; set; }
        public virtual ICollection<TIaIndicateurAssocie> TIaIndicateurAssocie { get; set; }
    }
}
