using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPAnneeFonds
    {
        public int IdAnneeFonds { get; set; }
        public int IdProgProjet { get; set; }
        public int IdAnnee { get; set; }
        public string Libelle { get; set; }
        public int Montant { get; set; }
    }
}
