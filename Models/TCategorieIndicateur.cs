using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TCategorieIndicateur
    {
        public int Id { get; set; }
        public string CatCode { get; set; }
        public string IndCode { get; set; }

        public virtual TCategorie CatCodeNavigation { get; set; }
        public virtual TIndicateur IndCodeNavigation { get; set; }
    }
}
