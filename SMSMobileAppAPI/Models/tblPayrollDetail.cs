using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblPayrollDetail
    {
        public long Id { get; set; }
        public long PayrollId { get; set; }
        public long ComponentId { get; set; }
        public decimal Value { get; set; }
        public long OrgId { get; set; }
        public virtual tblEmployeeSalaryComponent tblEmployeeSalaryComponent { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblPayroll tblPayroll { get; set; }
    }
}
