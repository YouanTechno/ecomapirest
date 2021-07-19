using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TPBailleur
    {
        public TPBailleur()
        {
            TPRMontant = new HashSet<TPRMontant>();
        }

        public int BaiId { get; set; }
        public string BaiNom { get; set; }
        public string BaiType { get; set; }
        public int? BaiTel { get; set; }
        public string BaiSigle { get; set; }
        public string BaiMail { get; set; }
        public string BaiSteWeb { get; set; }

        public virtual ICollection<TPRMontant> TPRMontant { get; set; }
    }
}
