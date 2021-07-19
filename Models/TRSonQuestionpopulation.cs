using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TRSonQuestionpopulation
    {
        public int QuespopId { get; set; }
        public int? QuespopQuesId { get; set; }
        public int? QuespopPopId { get; set; }
        public int? QuespopReponse { get; set; }

        public virtual TSonPopulation QuespopPop { get; set; }
        public virtual TSonQuestion QuespopQues { get; set; }
    }
}
