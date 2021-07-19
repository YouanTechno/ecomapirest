using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPCategorie
    {
        public TPCategorie()
        {
            TPProjet = new HashSet<TPProjet>();
        }

        public int CatId { get; set; }
        public string CatLibelle { get; set; }
        public string CatDescription { get; set; }

        public virtual ICollection<TPProjet> TPProjet { get; set; }
    }
}
