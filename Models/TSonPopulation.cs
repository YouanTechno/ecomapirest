using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSonPopulation
    {
        public TSonPopulation()
        {
            TRSonQuestionpopulation = new HashSet<TRSonQuestionpopulation>();
        }

        public int PopId { get; set; }
        public string PopPseudo { get; set; }
        public int? PopAge { get; set; }
        public string PopSexe { get; set; }
        public int? PopProfId { get; set; }

        public virtual TSonProfession PopProf { get; set; }
        public virtual ICollection<TRSonQuestionpopulation> TRSonQuestionpopulation { get; set; }
    }
}
