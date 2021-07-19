using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSonProfession
    {
        public TSonProfession()
        {
            TSonPopulation = new HashSet<TSonPopulation>();
        }

        public int ProfId { get; set; }
        public string ProfLibelle { get; set; }

        public virtual ICollection<TSonPopulation> TSonPopulation { get; set; }
    }
}
