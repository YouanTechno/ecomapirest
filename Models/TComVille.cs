using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TComVille
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public bool? IsDelete { get; set; }
    }
}
