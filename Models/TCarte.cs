using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TCarte
    {
        public int CarteId { get; set; }
        public string CarteLibelle { get; set; }
        public string CarteUrl { get; set; }
        public string CarteDescription { get; set; }
        public bool? CarteBActive { get; set; }
        public bool CarteBPublique { get; set; }
        public int? IdComVille { get; set; }
    }
}
