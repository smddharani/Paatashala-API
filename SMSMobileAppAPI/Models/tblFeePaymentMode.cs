using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblFeePaymentMode
    {
        public tblFeePaymentMode()
        {
            this.tblStudentFeePaidHeaders = new List<tblStudentFeePaidHeader>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblStudentFeePaidHeader> tblStudentFeePaidHeaders { get; set; }
    }
}
