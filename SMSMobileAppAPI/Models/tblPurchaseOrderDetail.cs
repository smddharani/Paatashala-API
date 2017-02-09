using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblPurchaseOrderDetail
    {
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public Nullable<long> ItemCode { get; set; }
        public Nullable<long> Item { get; set; }
        public Nullable<long> Quantity { get; set; }
        public Nullable<decimal> PricePerUnit { get; set; }
        public Nullable<decimal> DiscountPercent { get; set; }
        public Nullable<decimal> TaxPercent { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblPurchaseOrderHeader tblPurchaseOrderHeader { get; set; }
        public virtual tblStockGroup tblStockGroup { get; set; }
        public virtual tblStockItem tblStockItem { get; set; }
    }
}
