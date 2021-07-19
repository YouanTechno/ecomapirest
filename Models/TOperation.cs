using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TOperation
    {
        public int IdOperation { get; set; }
        public int? OpeId { get; set; }
        public string IndCodeGauche { get; set; }
        public string IndCodeDroit { get; set; }
        public int? IdOperationGauche { get; set; }
        public int? IdOperationDroit { get; set; }

        public virtual TIndicateur IndCodeDroitNavigation { get; set; }
        public virtual TIndicateur IndCodeGaucheNavigation { get; set; }
        public virtual TOperateur Ope { get; set; }
    }
}
