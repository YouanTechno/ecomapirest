using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TConfigurationSecurite
    {
        public int ConfsecId { get; set; }
        public int? ConfsecIaHautDroit { get; set; }
        public int? ConfsecIaBasDroit { get; set; }
        public string ConfsecCatCode { get; set; }

        public virtual TIaIndicateur ConfsecIaBasDroitNavigation { get; set; }
        public virtual TIaIndicateur ConfsecIaHautDroitNavigation { get; set; }
    }
}
