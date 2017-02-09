using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblTopic
    {
        public tblTopic()
        {
            this.tblQuestionBanks = new List<tblQuestionBank>();
        }

        public long TopicId { get; set; }
        public long SubjectId { get; set; }
        public string TopicName { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblQuestionBank> tblQuestionBanks { get; set; }
        public virtual tblSubject tblSubject { get; set; }
    }
}
