using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TIaIndicateurAssocie
    {
        public int IaIndId { get; set; }
        public int? IaIndIaId { get; set; }
        public string IaIndIndCode { get; set; }

        public virtual TIaIndicateur IaIndIa { get; set; }
        public virtual TIndicateur IaIndIndCodeNavigation { get; set; }
    }
}
