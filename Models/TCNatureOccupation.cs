using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TCNatureOccupation
    {
        public TCNatureOccupation()
        {
            TCBatiment = new HashSet<TCBatiment>();
            TCZoneInfos = new HashSet<TCZoneInfos>();
        }

        public string NatureCode { get; set; }
        public string NatureLibelle { get; set; }

        public virtual ICollection<TCBatiment> TCBatiment { get; set; }
        public virtual ICollection<TCZoneInfos> TCZoneInfos { get; set; }
    }
}
