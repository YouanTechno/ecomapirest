using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TComVilleQuartier
    {
        public int Id { get; set; }
        public string LibQuartier { get; set; }
        public int? IdComVille { get; set; }
    }
}
