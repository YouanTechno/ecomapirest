using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSonSondage
    {
        public TSonSondage()
        {
            TSonQuestion = new HashSet<TSonQuestion>();
        }

        public int SondId { get; set; }
        public string SondLibelle { get; set; }
        public DateTime? SondDate { get; set; }

        public virtual ICollection<TSonQuestion> TSonQuestion { get; set; }
    }
}
