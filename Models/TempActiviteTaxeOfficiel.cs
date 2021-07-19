using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TempActiviteTaxeOfficiel
    {
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string TaxeMensuelle { get; set; }
        public string TaxeMensuelleMoyenne { get; set; }
    }
}
