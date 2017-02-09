using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblGRN_PO_Detail
    {
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public Nullable<long> ItemCode { get; set; }
        public string ItemName { get; set; }
        public Nullable<long> Quantity { get; set; }
        public Nullable<decimal> PricePerUnit { get; set; }
        public Nullable<decimal> DiscountAmt { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public string Unit { get; set; }
        public string OrgId { get; set; }
    }
}
