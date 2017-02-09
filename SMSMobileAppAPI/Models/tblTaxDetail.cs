using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblTaxDetail
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public long TaxTypeId { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblTaxType tblTaxType { get; set; }
    }
}
