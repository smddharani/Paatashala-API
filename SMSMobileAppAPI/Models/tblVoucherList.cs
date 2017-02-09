using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblVoucherList
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long MasterVoucherId { get; set; }
        public long OrgId { get; set; }
        public virtual tblMasterVoucherList tblMasterVoucherList { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
