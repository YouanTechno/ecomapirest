using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSIncRepresentation
    {
        public TSIncRepresentation()
        {
            TSIncCategorie = new HashSet<TSIncCategorie>();
        }

        public int SiRepId { get; set; }
        public string SiRepCode { get; set; }
        public string SiRepDescription { get; set; }

        public virtual ICollection<TSIncCategorie> TSIncCategorie { get; set; }
    }
}
