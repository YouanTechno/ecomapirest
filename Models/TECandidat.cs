using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TECandidat
    {
        public TECandidat()
        {
            TREResulatObtenuCentre = new HashSet<TREResulatObtenuCentre>();
        }

        public int CandId { get; set; }
        public string CandMat { get; set; }
        public string CandNom { get; set; }
        public string CandPrenom { get; set; }
        public string CandDateNais { get; set; }
        public int? PartId { get; set; }
        public int? EchId { get; set; }
        public string Description { get; set; }

        public virtual TEEcheanceElectoral Ech { get; set; }
        public virtual TERegroupementPolitique Part { get; set; }
        public virtual ICollection<TREResulatObtenuCentre> TREResulatObtenuCentre { get; set; }
    }
}
