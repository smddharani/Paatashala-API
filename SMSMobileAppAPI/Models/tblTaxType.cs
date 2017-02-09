using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblTaxType
    {
        public tblTaxType()
        {
            this.tblTaxDetails = new List<tblTaxDetail>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public decimal TaxPercent { get; set; }
        public bool TaxAtSource { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblTaxDetail> tblTaxDetails { get; set; }
    }
}
