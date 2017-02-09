using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblEmpSalaryDetail
    {
        public long Id { get; set; }
        public Nullable<long> EmpId { get; set; }
        public Nullable<long> DeptId { get; set; }
        public Nullable<long> Designation { get; set; }
        public Nullable<System.DateTime> DateOfAppointment { get; set; }
        public Nullable<long> CategoryCode { get; set; }
        public string BankAccountNo { get; set; }
        public string BankLedgerNo { get; set; }
        public Nullable<System.DateTime> DateOfConfirmation { get; set; }
        public Nullable<bool> IsEligibleForPF { get; set; }
        public Nullable<decimal> BasicSalary { get; set; }
        public string PFNo { get; set; }
        public Nullable<decimal> IncrementAmt { get; set; }
        public long OrgId { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
