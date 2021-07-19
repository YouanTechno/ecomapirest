using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TVActiviteAnalyseNationalite
    {
        public int ActpaId { get; set; }
        public DateTime? ActpaDate { get; set; }
        public int? ActpaActId { get; set; }
        public int? ActpaTaxfId { get; set; }
        public string ActpaTaxfLiblelle { get; set; }
        public int? ActpaNatId { get; set; }
        public int? ActpaNombre { get; set; }
        public int? ActpaMontant { get; set; }
        public int? ActpaQuartierId { get; set; }
        public string ActpaQuartierLibelle { get; set; }
    }
}
