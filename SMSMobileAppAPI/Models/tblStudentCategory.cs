using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStudentCategory
    {
        public tblStudentCategory()
        {
            this.tblStudents = new List<tblStudent>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblStudent> tblStudents { get; set; }
    }
}
