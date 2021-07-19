using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPMaitreOuvrage
    {
        public TPMaitreOuvrage()
        {
            TPProjet = new HashSet<TPProjet>();
        }

        public int MouId { get; set; }
        public string MouNom { get; set; }

        public virtual ICollection<TPProjet> TPProjet { get; set; }
    }
}
