using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TModule
    {
        public TModule()
        {
            TIncident = new HashSet<TIncident>();
            TRAgentModuleDroit = new HashSet<TRAgentModuleDroit>();
        }

        public int ModId { get; set; }
        public string ModLibelle { get; set; }
        public string ModDescription { get; set; }

        public virtual ICollection<TIncident> TIncident { get; set; }
        public virtual ICollection<TRAgentModuleDroit> TRAgentModuleDroit { get; set; }
    }
}
