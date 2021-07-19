using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TIndicateur
    {
        public TIndicateur()
        {
            TCategorieIndicateur = new HashSet<TCategorieIndicateur>();
            TIaIndicateurAssocie = new HashSet<TIaIndicateurAssocie>();
            TOperationIndCodeDroitNavigation = new HashSet<TOperation>();
            TOperationIndCodeGaucheNavigation = new HashSet<TOperation>();
            TValeurIndicateurZone = new HashSet<TValeurIndicateurZone>();
        }

        public string IndCode { get; set; }
        public string IndLibelle { get; set; }
        public string IndDescription { get; set; }
        public string IndCodeRattache { get; set; }
        public string IndCodeParent { get; set; }
        public int? IdOperation { get; set; }
        public bool IndBNumerique { get; set; }

        public virtual ICollection<TCategorieIndicateur> TCategorieIndicateur { get; set; }
        public virtual ICollection<TIaIndicateurAssocie> TIaIndicateurAssocie { get; set; }
        public virtual ICollection<TOperation> TOperationIndCodeDroitNavigation { get; set; }
        public virtual ICollection<TOperation> TOperationIndCodeGaucheNavigation { get; set; }
        public virtual ICollection<TValeurIndicateurZone> TValeurIndicateurZone { get; set; }
    }
}
