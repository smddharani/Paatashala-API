using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblExamHall
    {
        public tblExamHall()
        {
            this.tblExamSchedules = new List<tblExamSchedule>();
        }

        public long Id { get; set; }
        public string HallNumber { get; set; }
        public Nullable<long> SeatingCapacity { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblExamSchedule> tblExamSchedules { get; set; }
    }
}
