using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TCategorie
    {
        public TCategorie()
        {
            TCategorieIndicateur = new HashSet<TCategorieIndicateur>();
        }

        public string CatCode { get; set; }
        public string CatLibelle { get; set; }
        public string CatDescription { get; set; }

        public virtual ICollection<TCategorieIndicateur> TCategorieIndicateur { get; set; }
    }
}
