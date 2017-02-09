using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStudentFeePaidHeader
    {
        public tblStudentFeePaidHeader()
        {
            this.tblFeePaidDetails = new List<tblFeePaidDetail>();
        }

        public long Id { get; set; }
        public long StudentId { get; set; }
        public System.DateTime DatePaid { get; set; }
        public string PaidForPeriod { get; set; }
        public long Course { get; set; }
        public long Batch { get; set; }
        public decimal GrandTotal { get; set; }
        public Nullable<long> PaymentMode { get; set; }
        public string PaymentDetails { get; set; }
        public Nullable<long> Bank { get; set; }
        public long OrgId { get; set; }
        public virtual tblBankDetail tblBankDetail { get; set; }
        public virtual ICollection<tblFeePaidDetail> tblFeePaidDetails { get; set; }
        public virtual tblFeePaymentMode tblFeePaymentMode { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}
