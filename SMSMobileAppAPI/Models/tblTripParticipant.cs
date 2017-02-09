using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblTripParticipant
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<long> TripSheetId { get; set; }
        public Nullable<long> PersonId { get; set; }
        public Nullable<long> PersonTypeId { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblTripSheet tblTripSheet { get; set; }
    }
}
