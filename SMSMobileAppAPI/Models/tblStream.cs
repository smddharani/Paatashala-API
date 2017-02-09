using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStream
    {
        public tblStream()
        {
            this.tblCourses = new List<tblCourse>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblCourse> tblCourses { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
