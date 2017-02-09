using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblDiscountType
    {
        public tblDiscountType()
        {
            this.tblStudents = new List<tblStudent>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblStudent> tblStudents { get; set; }
    }
}
