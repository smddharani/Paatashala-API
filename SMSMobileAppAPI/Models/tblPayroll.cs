using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblPayroll
    {
        public tblPayroll()
        {
            this.tblPayrollDetails = new List<tblPayrollDetail>();
        }

        public long Id { get; set; }
        public long EmpId { get; set; }
        public long Month { get; set; }
        public long year { get; set; }
        public long OrgId { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual ICollection<tblPayrollDetail> tblPayrollDetails { get; set; }
    }
}
