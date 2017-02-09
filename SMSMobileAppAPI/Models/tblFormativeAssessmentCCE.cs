using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblFormativeAssessmentCCE
    {
        public tblFormativeAssessmentCCE()
        {
            this.tblBlockCCEs = new List<tblBlockCCE>();
        }

        public long Id { get; set; }
        public long TermId { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblBlockCCE> tblBlockCCEs { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblTermCCE tblTermCCE { get; set; }
    }
}
