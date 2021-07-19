using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TMail
    {
        public TMail()
        {
            TMailAgent = new HashSet<TMailAgent>();
        }

        public int MailId { get; set; }
        public int? AgId { get; set; }
        public string MailObjet { get; set; }
        public DateTime? MailDate { get; set; }
        public string MailMessageEnrichi { get; set; }
        public string MailMessageSimple { get; set; }

        public virtual TAgent Ag { get; set; }
        public virtual ICollection<TMailAgent> TMailAgent { get; set; }
    }
}
