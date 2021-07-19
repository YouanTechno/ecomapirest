using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSonQuestion
    {
        public TSonQuestion()
        {
            TRSonQuestionpopulation = new HashSet<TRSonQuestionpopulation>();
        }

        public int QuesId { get; set; }
        public string QuesLibelle { get; set; }
        public int? QuesSondId { get; set; }

        public virtual TSonSondage QuesSond { get; set; }
        public virtual ICollection<TRSonQuestionpopulation> TRSonQuestionpopulation { get; set; }
    }
}
