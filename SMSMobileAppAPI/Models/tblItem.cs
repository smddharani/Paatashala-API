using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblItem
    {
        public tblItem()
        {
            this.tblItem_Vendor = new List<tblItem_Vendor>();
        }

        public long Id { get; set; }
        public Nullable<long> CategoryId { get; set; }
        public string ItemName { get; set; }
        public Nullable<long> ItemCode { get; set; }
        public Nullable<decimal> CostPrice { get; set; }
        public Nullable<long> Quantity { get; set; }
        public Nullable<long> RebatePercentCP { get; set; }
        public Nullable<long> RebateOnCP { get; set; }
        public Nullable<decimal> SPperUnit { get; set; }
        public Nullable<bool> IsVatIncluded { get; set; }
        public Nullable<decimal> MRPperUnit { get; set; }
        public Nullable<long> DiscountPercent { get; set; }
        public Nullable<decimal> CSTpercent { get; set; }
        public Nullable<long> ItemStatus { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<long> MinQuantity { get; set; }
        public Nullable<long> MaxQuantity { get; set; }
        public Nullable<System.DateTime> DateOfPurchase { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Shape { get; set; }
        public string Currency { get; set; }
        public byte[] Picture { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblItem_Vendor> tblItem_Vendor { get; set; }
        public virtual tblItemCategory tblItemCategory { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
