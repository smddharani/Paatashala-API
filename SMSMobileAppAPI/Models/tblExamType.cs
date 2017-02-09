using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblExamType
    {
        public tblExamType()
        {
            this.tblExamSchedules = new List<tblExamSchedule>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual ICollection<tblExamSchedule> tblExamSchedules { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
