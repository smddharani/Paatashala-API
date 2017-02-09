using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblService_InvoiceHeader
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string PONumber { get; set; }
        public Nullable<System.DateTime> PODate { get; set; }
        public Nullable<long> CustomerId { get; set; }
        public string Address { get; set; }
        public string TinOrCST { get; set; }
        public Nullable<long> TaxType { get; set; }
        public Nullable<long> TradeDiscountPercent { get; set; }
        public Nullable<long> SpecialDiscountPercent { get; set; }
        public Nullable<long> TotalTax { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
