using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TOperateur
    {
        public TOperateur()
        {
            TOperation = new HashSet<TOperation>();
        }

        public int OpeId { get; set; }
        public string OpeLibelle { get; set; }
        public string OpeDescription { get; set; }

        public virtual ICollection<TOperation> TOperation { get; set; }
    }
}
