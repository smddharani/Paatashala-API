using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblEmployeeSalaryComponent
    {
        public tblEmployeeSalaryComponent()
        {
            this.tblPayGroupDetails = new List<tblPayGroupDetail>();
            this.tblPayrollDetails = new List<tblPayrollDetail>();
        }

        public long Id { get; set; }
        public string ComponentName { get; set; }
        public bool IsDeduction { get; set; }
        public bool IsEarning { get; set; }
        public long Percentage { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblPayGroupDetail> tblPayGroupDetails { get; set; }
        public virtual ICollection<tblPayrollDetail> tblPayrollDetails { get; set; }
    }
}
