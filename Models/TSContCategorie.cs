using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TSContCategorie
    {
        public TSContCategorie()
        {
            TSContSouscategorie = new HashSet<TSContSouscategorie>();
        }

        public int ScCatId { get; set; }
        public string ScCatLibelle { get; set; }
        public string ScCatDescription { get; set; }
        public bool? ScCatBSecurite { get; set; }

        public virtual ICollection<TSContSouscategorie> TSContSouscategorie { get; set; }
    }
}
