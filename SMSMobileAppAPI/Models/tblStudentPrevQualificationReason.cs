using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStudentPrevQualificationReason
    {
        public tblStudentPrevQualificationReason()
        {
            this.tblStudentQualifications = new List<tblStudentQualification>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblStudentQualification> tblStudentQualifications { get; set; }
    }
}
