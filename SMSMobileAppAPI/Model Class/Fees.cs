using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSMobileAppAPI.Model_Class
{
    public class Fees
    {
        public List<FeeAmount> FeepaidList { get; set; }
        public Fees()
        {
            FeepaidList = new List<FeeAmount>();
        }
    }
    public class FeeAmount
    {
        public string Date { get; set; }
        public Decimal GrandTotal { get; set; }
        public string PaidForPeriod { get; set; }
        public string PaymentMode { get; set; }

    }
}