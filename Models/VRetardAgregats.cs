using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class VRetardAgregats
    {
        public int Id { get; set; }
        public double? Montant { get; set; }
        public int? Nombre { get; set; }
        public string Periode { get; set; }
    }
}
