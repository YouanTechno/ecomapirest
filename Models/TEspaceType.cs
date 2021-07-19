using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TEspaceType
    {
        public TEspaceType()
        {
            TEspacemarche = new HashSet<TEspacemarche>();
        }

        public int EsptypId { get; set; }
        public string EsptypLibelle { get; set; }
        public string EsptypDescription { get; set; }

        public virtual ICollection<TEspacemarche> TEspacemarche { get; set; }
    }
}
