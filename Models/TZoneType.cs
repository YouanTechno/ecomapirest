using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TZoneType
    {
        public TZoneType()
        {
            TConfigurationConfDecoupageCadastreNavigation = new HashSet<TConfiguration>();
            TConfigurationConfDecoupageCommuneNavigation = new HashSet<TConfiguration>();
            TZoneCategorie = new HashSet<TZoneCategorie>();
        }

        public int IdTypezone { get; set; }
        public string TypezoneLibelle { get; set; }
        public string TypezoneDescription { get; set; }
        public bool? TypezoneBEstActif { get; set; }

        public virtual ICollection<TConfiguration> TConfigurationConfDecoupageCadastreNavigation { get; set; }
        public virtual ICollection<TConfiguration> TConfigurationConfDecoupageCommuneNavigation { get; set; }
        public virtual ICollection<TZoneCategorie> TZoneCategorie { get; set; }
    }
}
