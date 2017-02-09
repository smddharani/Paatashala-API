using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAccountGroup
    {
        public tblAccountGroup()
        {
            this.tblAccountLedgers = new List<tblAccountLedger>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblAccountLedger> tblAccountLedgers { get; set; }
    }
}
