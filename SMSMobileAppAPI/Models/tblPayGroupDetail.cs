using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblPayGroupDetail
    {
        public long Id { get; set; }
        public Nullable<long> PayGroupId { get; set; }
        public Nullable<long> SalaryComponent { get; set; }
        public Nullable<long> CalculationType { get; set; }
        public Nullable<long> ComputedOn { get; set; }
        public Nullable<decimal> Value { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblEmployeeSalaryComponent tblEmployeeSalaryComponent { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblPayGroup tblPayGroup { get; set; }
    }
}
