using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblProforma_ServiceInvoiceHeader
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<long> PONumber { get; set; }
        public Nullable<System.DateTime> PODate { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public Nullable<long> TinOrCST { get; set; }
        public Nullable<long> TaxType { get; set; }
        public Nullable<long> TradeDiscountPercent { get; set; }
        public Nullable<long> SpecialDiscountPercent { get; set; }
        public Nullable<long> TotalTax { get; set; }
        public Nullable<long> Total { get; set; }
    }
}
