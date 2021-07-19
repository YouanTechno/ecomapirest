using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TActivite
    {
        public TActivite()
        {
            TResTaxeactivite = new HashSet<TResTaxeactivite>();
        }

        public int ActId { get; set; }
        public DateTime? ActDate { get; set; }
        public int? ActProId { get; set; }
        public int? ActEnseignId { get; set; }
        public string ActEnseignLibelle { get; set; }
        public int? ActEspmarchId { get; set; }
        public string ActPlaque { get; set; }
        public int? ActZiId { get; set; }
        public int? ActContId { get; set; }
        public string ActArticle { get; set; }
        public int? ActActId { get; set; }
        public int? ActTaId { get; set; }

        public virtual TResActivite ActAct { get; set; }
        public virtual TCContribuable ActCont { get; set; }
        public virtual TEspacemarche ActEspmarch { get; set; }
        public virtual TProprietaire ActPro { get; set; }
        public virtual ICollection<TResTaxeactivite> TResTaxeactivite { get; set; }
    }
}
