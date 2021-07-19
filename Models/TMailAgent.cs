using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TMailAgent
    {
        public int IdMailAgent { get; set; }
        public int? AgId { get; set; }
        public int? MailId { get; set; }
        public bool MailAgBLecture { get; set; }
        public DateTime? MailAgDateLecture { get; set; }

        public virtual TAgent Ag { get; set; }
        public virtual TMail Mail { get; set; }
    }
}
