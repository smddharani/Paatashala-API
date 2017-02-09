using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblGlobalOrgSetting
    {
        public long Id { get; set; }
        public Nullable<bool> MandatoryFeeOnAdmission { get; set; }
        public Nullable<long> Country { get; set; }
        public Nullable<bool> FeePaymentSchedule { get; set; }
        public Nullable<long> TimeZone { get; set; }
        public Nullable<long> BarcodeType { get; set; }
        public string HeaderHTML { get; set; }
        public string FooterHTML { get; set; }
        public string TermsAndConditionPayment { get; set; }
        public string BirthdayEmailContent { get; set; }
        public string AnniversaryEmailContent { get; set; }
        public long OrgId { get; set; }
        public virtual tblBarCodeSymbology tblBarCodeSymbology { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
