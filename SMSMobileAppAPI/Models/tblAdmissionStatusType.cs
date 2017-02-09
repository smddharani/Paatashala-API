using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAdmissionStatusType
    {
        public tblAdmissionStatusType()
        {
            this.tblStudentRegistrations = new List<tblStudentRegistration>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<tblStudentRegistration> tblStudentRegistrations { get; set; }
    }
}
