using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblTermCCE
    {
        public tblTermCCE()
        {
            this.tblFormativeAssessmentCCEs = new List<tblFormativeAssessmentCCE>();
            this.tblLearnoMeterCCEs = new List<tblLearnoMeterCCE>();
            this.tblSummativeAssessmentCCEs = new List<tblSummativeAssessmentCCE>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblFormativeAssessmentCCE> tblFormativeAssessmentCCEs { get; set; }
        public virtual ICollection<tblLearnoMeterCCE> tblLearnoMeterCCEs { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblSummativeAssessmentCCE> tblSummativeAssessmentCCEs { get; set; }
    }
}
