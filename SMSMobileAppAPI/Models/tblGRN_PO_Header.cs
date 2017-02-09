using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblGRN_PO_Header
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> GRNDate { get; set; }
        public Nullable<long> VendorId { get; set; }
        public string Address { get; set; }
        public string PONo { get; set; }
        public Nullable<long> TaxType { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<decimal> TotalTax { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
