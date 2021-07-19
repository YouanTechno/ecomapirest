using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TZoneSecteur
    {
        public TZoneSecteur()
        {
            TZone = new HashSet<TZone>();
        }

        public int SecId { get; set; }
        public string SecLibelle { get; set; }
        public string SecDescription { get; set; }

        public virtual ICollection<TZone> TZone { get; set; }
    }
}
