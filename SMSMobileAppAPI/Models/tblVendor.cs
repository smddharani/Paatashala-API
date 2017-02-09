using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblVendor
    {
        public tblVendor()
        {
            this.tblItem_Vendor = new List<tblItem_Vendor>();
            this.tblPurchaseOrderHeaders = new List<tblPurchaseOrderHeader>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public string BalanceType { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public Nullable<long> Phone { get; set; }
        public Nullable<long> Mobile { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public Nullable<long> TinOrLst { get; set; }
        public Nullable<long> CSTNumber { get; set; }
        public Nullable<long> TradeDiscountPercent { get; set; }
        public Nullable<long> CashDiscount { get; set; }
        public Nullable<long> TradeDiscount { get; set; }
        public Nullable<bool> CreditAllow { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblItem_Vendor> tblItem_Vendor { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblPurchaseOrderHeader> tblPurchaseOrderHeaders { get; set; }
    }
}
