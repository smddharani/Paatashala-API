using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblMedicineDetail
    {
        public tblMedicineDetail()
        {
            this.tblStudentMedicines = new List<tblStudentMedicine>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblStudentMedicine> tblStudentMedicines { get; set; }
    }
}
