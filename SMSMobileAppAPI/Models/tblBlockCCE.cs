using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblBlockCCE
    {
        public tblBlockCCE()
        {
            this.tblSubBlockCCEs = new List<tblSubBlockCCE>();
        }

        public long Id { get; set; }
        public long FormativeAssessmentId { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual tblFormativeAssessmentCCE tblFormativeAssessmentCCE { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblSubBlockCCE> tblSubBlockCCEs { get; set; }
    }
}
