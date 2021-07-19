using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TAgent
    {
        public TAgent()
        {
            TAgentCollecteur = new HashSet<TAgentCollecteur>();
            TIncident = new HashSet<TIncident>();
            TMail = new HashSet<TMail>();
            TMailAgent = new HashSet<TMailAgent>();
            TRAgentModuleDroit = new HashSet<TRAgentModuleDroit>();
            TResCollecte = new HashSet<TResCollecte>();
            TResMetafacture = new HashSet<TResMetafacture>();
            TTraces = new HashSet<TTraces>();
        }

        public int AgId { get; set; }
        public string AgLogin { get; set; }
        public string AgPass { get; set; }
        public string AgNom { get; set; }
        public string AgPrenoms { get; set; }

        public virtual TErreur TErreur { get; set; }
        public virtual ICollection<TAgentCollecteur> TAgentCollecteur { get; set; }
        public virtual ICollection<TIncident> TIncident { get; set; }
        public virtual ICollection<TMail> TMail { get; set; }
        public virtual ICollection<TMailAgent> TMailAgent { get; set; }
        public virtual ICollection<TRAgentModuleDroit> TRAgentModuleDroit { get; set; }
        public virtual ICollection<TResCollecte> TResCollecte { get; set; }
        public virtual ICollection<TResMetafacture> TResMetafacture { get; set; }
        public virtual ICollection<TTraces> TTraces { get; set; }
    }
}
