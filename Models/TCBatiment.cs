using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TCBatiment
    {
        public TCBatiment()
        {
            TRCBatimentContribuable = new HashSet<TRCBatimentContribuable>();
        }

        public int BatId { get; set; }
        public int? BatNiv { get; set; }
        public int? BatNbAppart { get; set; }
        public string BatNatureCode { get; set; }
        public string BatAffectation { get; set; }
        public int? BatZiId { get; set; }

        public virtual TCNatureOccupation BatNatureCodeNavigation { get; set; }
        public virtual TCZoneInfos BatZi { get; set; }
        public virtual ICollection<TRCBatimentContribuable> TRCBatimentContribuable { get; set; }
    }
}
