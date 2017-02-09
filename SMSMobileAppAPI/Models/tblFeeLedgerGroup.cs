using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblFeeLedgerGroup
    {
        public tblFeeLedgerGroup()
        {
            this.tblFeeItemDetails = new List<tblFeeItemDetail>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string LedgerCode { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblFeeItemDetail> tblFeeItemDetails { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
