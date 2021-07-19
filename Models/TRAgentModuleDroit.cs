using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TRAgentModuleDroit
    {
        public int AmdId { get; set; }
        public int AmdIdagent { get; set; }
        public int AmdIdmodule { get; set; }
        public int AmdIddroit { get; set; }

        public virtual TAgent AmdIdagentNavigation { get; set; }
        public virtual TDroit AmdIddroitNavigation { get; set; }
        public virtual TModule AmdIdmoduleNavigation { get; set; }
    }
}
