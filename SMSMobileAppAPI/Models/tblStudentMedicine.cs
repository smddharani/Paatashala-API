using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStudentMedicine
    {
        public long Id { get; set; }
        public Nullable<long> StudentId { get; set; }
        public Nullable<System.DateTime> AdministeredDate { get; set; }
        public Nullable<long> MedicineId { get; set; }
        public string UOM { get; set; }
        public long OrgId { get; set; }
        public virtual tblMedicineDetail tblMedicineDetail { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
