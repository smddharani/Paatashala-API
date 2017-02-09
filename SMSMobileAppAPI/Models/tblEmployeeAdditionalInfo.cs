using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblEmployeeAdditionalInfo
    {
        public long Id { get; set; }
        public Nullable<long> EmpId { get; set; }
        public string Col1 { get; set; }
        public string Col1Details { get; set; }
        public string Col2 { get; set; }
        public string Col2Details { get; set; }
        public string Col3 { get; set; }
        public string Col3Details { get; set; }
        public string Col4 { get; set; }
        public string Col4Details { get; set; }
        public string Col5 { get; set; }
        public string Col5Details { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
