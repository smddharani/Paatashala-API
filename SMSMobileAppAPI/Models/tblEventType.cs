using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblEventType
    {
        public tblEventType()
        {
            this.tblEvents = new List<tblEvent>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<long> PersonId { get; set; }
        public Nullable<long> PersonType { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual ICollection<tblEvent> tblEvents { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
