using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TDroit
    {
        public TDroit()
        {
            TRAgentModuleDroit = new HashSet<TRAgentModuleDroit>();
        }

        public int DroId { get; set; }
        public string DroLibelle { get; set; }
        public string DroDescription { get; set; }

        public virtual ICollection<TRAgentModuleDroit> TRAgentModuleDroit { get; set; }
    }
}
