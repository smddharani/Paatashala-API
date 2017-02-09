using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblQuestionBank
    {
        public long QBankId { get; set; }
        public long TopicId { get; set; }
        public string QuestionHTML { get; set; }
        public string AnswerHTML { get; set; }
        public long OrgId { get; set; }
        public double MarksForQuestion { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblTopic tblTopic { get; set; }
    }
}
