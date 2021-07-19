using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TMarche
    {
        public TMarche()
        {
            TEspacemarche = new HashSet<TEspacemarche>();
        }

        public int MarchId { get; set; }
        public string MarchLibelle { get; set; }
        public string MarchDescription { get; set; }

        public virtual ICollection<TEspacemarche> TEspacemarche { get; set; }
    }
}
