using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPMaitreOeuvre
    {
        public TPMaitreOeuvre()
        {
            TPProjet = new HashSet<TPProjet>();
        }

        public int MoeId { get; set; }
        public string MoeNom { get; set; }
        public string MoeContact { get; set; }

        public virtual ICollection<TPProjet> TPProjet { get; set; }
    }
}
