using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblOrg
    {
        public tblOrg()
        {
            this.CounsellorNotes = new List<CounsellorNote>();
            this.tblAccountGroups = new List<tblAccountGroup>();
            this.tblAccountLedgers = new List<tblAccountLedger>();
            this.tblAssetAttributes = new List<tblAssetAttribute>();
            this.tblAssetCategories = new List<tblAssetCategory>();
            this.tblAssetCategoryAttributes = new List<tblAssetCategoryAttribute>();
            this.tblAssets = new List<tblAsset>();
            this.tblAssignments = new List<tblAssignment>();
            this.tblAssignmentQuestions = new List<tblAssignmentQuestion>();
            this.tblAttendances = new List<tblAttendance>();
            this.tblAttendanceHourlies = new List<tblAttendanceHourly>();
            this.tblBankDetails = new List<tblBankDetail>();
            this.tblBatches = new List<tblBatch>();
            this.tblBatchAdmissions = new List<tblBatchAdmission>();
            this.tblBatchAdmissionArchives = new List<tblBatchAdmissionArchive>();
            this.tblBatchAdmissionPasts = new List<tblBatchAdmissionPast>();
            this.tblBlockAttributesCCEs = new List<tblBlockAttributesCCE>();
            this.tblBlockCCEs = new List<tblBlockCCE>();
            this.tblBranches = new List<tblBranch>();
            this.tblCastes = new List<tblCaste>();
            this.tblCertificates = new List<tblCertificate>();
            this.tblCirculars = new List<tblCircular>();
            this.tblCounsellors = new List<tblCounsellor>();
            this.tblCourses = new List<tblCourse>();
            this.tblCourse_Subject = new List<tblCourse_Subject>();
            this.tblCourseFeeDetails = new List<tblCourseFeeDetail>();
            this.tblCustomers = new List<tblCustomer>();
            this.tblDepartments = new List<tblDepartment>();
            this.tblDesignations = new List<tblDesignation>();
            this.tblDietaryItems = new List<tblDietaryItem>();
            this.tblDietPlans = new List<tblDietPlan>();
            this.tblDietPlanDetails = new List<tblDietPlanDetail>();
            this.tblDiscountTypes = new List<tblDiscountType>();
            this.tblDrivers = new List<tblDriver>();
            this.tblEmployees = new List<tblEmployee>();
            this.tblEmployeeAdditionalInfoes = new List<tblEmployeeAdditionalInfo>();
            this.tblEmployeeAttachments = new List<tblEmployeeAttachment>();
            this.tblEmployeeAttendances = new List<tblEmployeeAttendance>();
            this.tblEmployeeAttendances1 = new List<tblEmployeeAttendance>();
            this.tblEmployeeLeaveTypes = new List<tblEmployeeLeaveType>();
            this.tblEmployeeSalaryComponents = new List<tblEmployeeSalaryComponent>();
            this.tblEmpSalaryDetails = new List<tblEmpSalaryDetail>();
            this.tblEvents = new List<tblEvent>();
            this.tblEventTypes = new List<tblEventType>();
            this.tblExamHalls = new List<tblExamHall>();
            this.tblExamMarks = new List<tblExamMark>();
            this.tblExamSchedules = new List<tblExamSchedule>();
            this.tblExamTypes = new List<tblExamType>();
            this.tblFeeInstallmentDetails = new List<tblFeeInstallmentDetail>();
            this.tblFeeItemDetails = new List<tblFeeItemDetail>();
            this.tblFeeLedgerGroups = new List<tblFeeLedgerGroup>();
            this.tblFeePaidDetails = new List<tblFeePaidDetail>();
            this.tblFeePaymentModes = new List<tblFeePaymentMode>();
            this.tblFormativeAssessmentCCEs = new List<tblFormativeAssessmentCCE>();
            this.tblGlobalOrgSettings = new List<tblGlobalOrgSetting>();
            this.tblGPSDatas = new List<tblGPSData>();
            this.tblHolidayLists = new List<tblHolidayList>();
            this.tblHostels = new List<tblHostel>();
            this.tblHostel_Room = new List<tblHostel_Room>();
            this.tblHostel_Room_Student = new List<tblHostel_Room_Student>();
            this.tblHostelBillings = new List<tblHostelBilling>();
            this.tblHostelRooms = new List<tblHostelRoom>();
            this.tblHostelTypes = new List<tblHostelType>();
            this.tblImageGalleries = new List<tblImageGallery>();
            this.tblInstitutions = new List<tblInstitution>();
            this.tblIssueLists = new List<tblIssueList>();
            this.tblItem_Vendor = new List<tblItem_Vendor>();
            this.tblItemCategories = new List<tblItemCategory>();
            this.tblItems = new List<tblItem>();
            this.tblLeadFollowUps = new List<tblLeadFollowUp>();
            this.tblLearnoMeterCCEs = new List<tblLearnoMeterCCE>();
            this.tblLibraries = new List<tblLibrary>();
            this.tblLibraryBooks = new List<tblLibraryBook>();
            this.tblLibraryBookAuthors = new List<tblLibraryBookAuthor>();
            this.tblLibraryBookCategories = new List<tblLibraryBookCategory>();
            this.tblLibraryBookEditions = new List<tblLibraryBookEdition>();
            this.tblLibraryBookLedgers = new List<tblLibraryBookLedger>();
            this.tblLibraryBookPublications = new List<tblLibraryBookPublication>();
            this.tblLibraryBookVolumes = new List<tblLibraryBookVolume>();
            this.tblLogins = new List<tblLogin>();
            this.tblMedicineDetails = new List<tblMedicineDetail>();
            this.tblMessageAttachments = new List<tblMessageAttachment>();
            this.tblMessageCenters = new List<tblMessageCenter>();
            this.tblMessageRecipients = new List<tblMessageRecipient>();
            this.tblNationalities = new List<tblNationality>();
            this.tblPayGroups = new List<tblPayGroup>();
            this.tblPayGroupDetails = new List<tblPayGroupDetail>();
            this.tblPayrollDetails = new List<tblPayrollDetail>();
            this.tblPurchaseOrderDetails = new List<tblPurchaseOrderDetail>();
            this.tblPurchaseOrderHeaders = new List<tblPurchaseOrderHeader>();
            this.tblQuestionBanks = new List<tblQuestionBank>();
            this.tblRoles = new List<tblRole>();
            this.tblRolePermissions = new List<tblRolePermission>();
            this.tblRoute_Stops = new List<tblRoute_Stops>();
            this.tblRoute_Vehicle = new List<tblRoute_Vehicle>();
            this.tblRoutes = new List<tblRoute>();
            this.tblRouteStops = new List<tblRouteStop>();
            this.tblStockGroups = new List<tblStockGroup>();
            this.tblStockItems = new List<tblStockItem>();
            this.tblStreams = new List<tblStream>();
            this.tblStudents = new List<tblStudent>();
            this.tblStudentAttachments = new List<tblStudentAttachment>();
            this.tblStudentCategories = new List<tblStudentCategory>();
            this.tblStudentCustomizes = new List<tblStudentCustomize>();
            this.tblStudentCustomizeValues = new List<tblStudentCustomizeValue>();
            this.tblStudentFeePaidHeaders = new List<tblStudentFeePaidHeader>();
            this.tblStudentMedicines = new List<tblStudentMedicine>();
            this.tblStudentPrevQualificationReasons = new List<tblStudentPrevQualificationReason>();
            this.tblStudentQualifications = new List<tblStudentQualification>();
            this.tblStudentRegistrations = new List<tblStudentRegistration>();
            this.tblStudentResultsCCEs = new List<tblStudentResultsCCE>();
            this.tblStudentValues = new List<tblStudentValue>();
            this.tblSubBlockCCEs = new List<tblSubBlockCCE>();
            this.tblSubCastes = new List<tblSubCaste>();
            this.tblSubjects = new List<tblSubject>();
            this.tblSummativeAssessmentCCEs = new List<tblSummativeAssessmentCCE>();
            this.tblTaxDetails = new List<tblTaxDetail>();
            this.tblTaxTypes = new List<tblTaxType>();
            this.tblTermCCEs = new List<tblTermCCE>();
            this.tblTimeTables = new List<tblTimeTable>();
            this.tblTimetable_workingDays = new List<tblTimetable_workingDays>();
            this.tblTimeTableDetails = new List<tblTimeTableDetail>();
            this.tblTopics = new List<tblTopic>();
            this.tblTransportPayments = new List<tblTransportPayment>();
            this.tblTransportTripSheets = new List<tblTransportTripSheet>();
            this.tblTripParticipants = new List<tblTripParticipant>();
            this.tblTripSheets = new List<tblTripSheet>();
            this.tblUnitOfMeasures = new List<tblUnitOfMeasure>();
            this.tblVehicles = new List<tblVehicle>();
            this.tblVehicleTypes = new List<tblVehicleType>();
            this.tblVendors = new List<tblVendor>();
            this.tblVisitorMaterials = new List<tblVisitorMaterial>();
            this.tblVisitors = new List<tblVisitor>();
            this.tblVoucherLists = new List<tblVoucherList>();
        }

        public long Id { get; set; }
        public string OrgName { get; set; }
        public string OrgFullName { get; set; }
        public string PrimaryContact { get; set; }
        public Nullable<long> Mobile { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public Nullable<System.DateTime> SubscriptionStartDate { get; set; }
        public Nullable<System.DateTime> SubscriptionEndDate { get; set; }
        public byte[] OrgPhoto { get; set; }
        public virtual ICollection<CounsellorNote> CounsellorNotes { get; set; }
        public virtual ICollection<tblAccountGroup> tblAccountGroups { get; set; }
        public virtual ICollection<tblAccountLedger> tblAccountLedgers { get; set; }
        public virtual ICollection<tblAssetAttribute> tblAssetAttributes { get; set; }
        public virtual ICollection<tblAssetCategory> tblAssetCategories { get; set; }
        public virtual ICollection<tblAssetCategoryAttribute> tblAssetCategoryAttributes { get; set; }
        public virtual ICollection<tblAsset> tblAssets { get; set; }
        public virtual ICollection<tblAssignment> tblAssignments { get; set; }
        public virtual ICollection<tblAssignmentQuestion> tblAssignmentQuestions { get; set; }
        public virtual ICollection<tblAttendance> tblAttendances { get; set; }
        public virtual ICollection<tblAttendanceHourly> tblAttendanceHourlies { get; set; }
        public virtual ICollection<tblBankDetail> tblBankDetails { get; set; }
        public virtual ICollection<tblBatch> tblBatches { get; set; }
        public virtual ICollection<tblBatchAdmission> tblBatchAdmissions { get; set; }
        public virtual ICollection<tblBatchAdmissionArchive> tblBatchAdmissionArchives { get; set; }
        public virtual ICollection<tblBatchAdmissionPast> tblBatchAdmissionPasts { get; set; }
        public virtual ICollection<tblBlockAttributesCCE> tblBlockAttributesCCEs { get; set; }
        public virtual ICollection<tblBlockCCE> tblBlockCCEs { get; set; }
        public virtual ICollection<tblBranch> tblBranches { get; set; }
        public virtual ICollection<tblCaste> tblCastes { get; set; }
        public virtual ICollection<tblCertificate> tblCertificates { get; set; }
        public virtual ICollection<tblCircular> tblCirculars { get; set; }
        public virtual ICollection<tblCounsellor> tblCounsellors { get; set; }
        public virtual ICollection<tblCourse> tblCourses { get; set; }
        public virtual ICollection<tblCourse_Subject> tblCourse_Subject { get; set; }
        public virtual ICollection<tblCourseFeeDetail> tblCourseFeeDetails { get; set; }
        public virtual ICollection<tblCustomer> tblCustomers { get; set; }
        public virtual ICollection<tblDepartment> tblDepartments { get; set; }
        public virtual ICollection<tblDesignation> tblDesignations { get; set; }
        public virtual ICollection<tblDietaryItem> tblDietaryItems { get; set; }
        public virtual ICollection<tblDietPlan> tblDietPlans { get; set; }
        public virtual ICollection<tblDietPlanDetail> tblDietPlanDetails { get; set; }
        public virtual ICollection<tblDiscountType> tblDiscountTypes { get; set; }
        public virtual ICollection<tblDriver> tblDrivers { get; set; }
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }
        public virtual ICollection<tblEmployeeAdditionalInfo> tblEmployeeAdditionalInfoes { get; set; }
        public virtual ICollection<tblEmployeeAttachment> tblEmployeeAttachments { get; set; }
        public virtual ICollection<tblEmployeeAttendance> tblEmployeeAttendances { get; set; }
        public virtual ICollection<tblEmployeeAttendance> tblEmployeeAttendances1 { get; set; }
        public virtual ICollection<tblEmployeeLeaveType> tblEmployeeLeaveTypes { get; set; }
        public virtual ICollection<tblEmployeeSalaryComponent> tblEmployeeSalaryComponents { get; set; }
        public virtual ICollection<tblEmpSalaryDetail> tblEmpSalaryDetails { get; set; }
        public virtual ICollection<tblEvent> tblEvents { get; set; }
        public virtual ICollection<tblEventType> tblEventTypes { get; set; }
        public virtual ICollection<tblExamHall> tblExamHalls { get; set; }
        public virtual ICollection<tblExamMark> tblExamMarks { get; set; }
        public virtual ICollection<tblExamSchedule> tblExamSchedules { get; set; }
        public virtual ICollection<tblExamType> tblExamTypes { get; set; }
        public virtual ICollection<tblFeeInstallmentDetail> tblFeeInstallmentDetails { get; set; }
        public virtual ICollection<tblFeeItemDetail> tblFeeItemDetails { get; set; }
        public virtual ICollection<tblFeeLedgerGroup> tblFeeLedgerGroups { get; set; }
        public virtual ICollection<tblFeePaidDetail> tblFeePaidDetails { get; set; }
        public virtual ICollection<tblFeePaymentMode> tblFeePaymentModes { get; set; }
        public virtual ICollection<tblFormativeAssessmentCCE> tblFormativeAssessmentCCEs { get; set; }
        public virtual ICollection<tblGlobalOrgSetting> tblGlobalOrgSettings { get; set; }
        public virtual ICollection<tblGPSData> tblGPSDatas { get; set; }
        public virtual ICollection<tblHolidayList> tblHolidayLists { get; set; }
        public virtual ICollection<tblHostel> tblHostels { get; set; }
        public virtual ICollection<tblHostel_Room> tblHostel_Room { get; set; }
        public virtual ICollection<tblHostel_Room_Student> tblHostel_Room_Student { get; set; }
        public virtual ICollection<tblHostelBilling> tblHostelBillings { get; set; }
        public virtual ICollection<tblHostelRoom> tblHostelRooms { get; set; }
        public virtual ICollection<tblHostelType> tblHostelTypes { get; set; }
        public virtual ICollection<tblImageGallery> tblImageGalleries { get; set; }
        public virtual ICollection<tblInstitution> tblInstitutions { get; set; }
        public virtual ICollection<tblIssueList> tblIssueLists { get; set; }
        public virtual ICollection<tblItem_Vendor> tblItem_Vendor { get; set; }
        public virtual ICollection<tblItemCategory> tblItemCategories { get; set; }
        public virtual ICollection<tblItem> tblItems { get; set; }
        public virtual ICollection<tblLeadFollowUp> tblLeadFollowUps { get; set; }
        public virtual ICollection<tblLearnoMeterCCE> tblLearnoMeterCCEs { get; set; }
        public virtual ICollection<tblLibrary> tblLibraries { get; set; }
        public virtual ICollection<tblLibraryBook> tblLibraryBooks { get; set; }
        public virtual ICollection<tblLibraryBookAuthor> tblLibraryBookAuthors { get; set; }
        public virtual ICollection<tblLibraryBookCategory> tblLibraryBookCategories { get; set; }
        public virtual ICollection<tblLibraryBookEdition> tblLibraryBookEditions { get; set; }
        public virtual ICollection<tblLibraryBookLedger> tblLibraryBookLedgers { get; set; }
        public virtual ICollection<tblLibraryBookPublication> tblLibraryBookPublications { get; set; }
        public virtual ICollection<tblLibraryBookVolume> tblLibraryBookVolumes { get; set; }
        public virtual ICollection<tblLogin> tblLogins { get; set; }
        public virtual ICollection<tblMedicineDetail> tblMedicineDetails { get; set; }
        public virtual ICollection<tblMessageAttachment> tblMessageAttachments { get; set; }
        public virtual ICollection<tblMessageCenter> tblMessageCenters { get; set; }
        public virtual ICollection<tblMessageRecipient> tblMessageRecipients { get; set; }
        public virtual ICollection<tblNationality> tblNationalities { get; set; }
        public virtual ICollection<tblPayGroup> tblPayGroups { get; set; }
        public virtual ICollection<tblPayGroupDetail> tblPayGroupDetails { get; set; }
        public virtual ICollection<tblPayrollDetail> tblPayrollDetails { get; set; }
        public virtual ICollection<tblPurchaseOrderDetail> tblPurchaseOrderDetails { get; set; }
        public virtual ICollection<tblPurchaseOrderHeader> tblPurchaseOrderHeaders { get; set; }
        public virtual ICollection<tblQuestionBank> tblQuestionBanks { get; set; }
        public virtual ICollection<tblRole> tblRoles { get; set; }
        public virtual ICollection<tblRolePermission> tblRolePermissions { get; set; }
        public virtual ICollection<tblRoute_Stops> tblRoute_Stops { get; set; }
        public virtual ICollection<tblRoute_Vehicle> tblRoute_Vehicle { get; set; }
        public virtual ICollection<tblRoute> tblRoutes { get; set; }
        public virtual ICollection<tblRouteStop> tblRouteStops { get; set; }
        public virtual ICollection<tblStockGroup> tblStockGroups { get; set; }
        public virtual ICollection<tblStockItem> tblStockItems { get; set; }
        public virtual ICollection<tblStream> tblStreams { get; set; }
        public virtual ICollection<tblStudent> tblStudents { get; set; }
        public virtual ICollection<tblStudentAttachment> tblStudentAttachments { get; set; }
        public virtual ICollection<tblStudentCategory> tblStudentCategories { get; set; }
        public virtual ICollection<tblStudentCustomize> tblStudentCustomizes { get; set; }
        public virtual ICollection<tblStudentCustomizeValue> tblStudentCustomizeValues { get; set; }
        public virtual ICollection<tblStudentFeePaidHeader> tblStudentFeePaidHeaders { get; set; }
        public virtual ICollection<tblStudentMedicine> tblStudentMedicines { get; set; }
        public virtual ICollection<tblStudentPrevQualificationReason> tblStudentPrevQualificationReasons { get; set; }
        public virtual ICollection<tblStudentQualification> tblStudentQualifications { get; set; }
        public virtual ICollection<tblStudentRegistration> tblStudentRegistrations { get; set; }
        public virtual ICollection<tblStudentResultsCCE> tblStudentResultsCCEs { get; set; }
        public virtual ICollection<tblStudentValue> tblStudentValues { get; set; }
        public virtual ICollection<tblSubBlockCCE> tblSubBlockCCEs { get; set; }
        public virtual ICollection<tblSubCaste> tblSubCastes { get; set; }
        public virtual ICollection<tblSubject> tblSubjects { get; set; }
        public virtual ICollection<tblSummativeAssessmentCCE> tblSummativeAssessmentCCEs { get; set; }
        public virtual ICollection<tblTaxDetail> tblTaxDetails { get; set; }
        public virtual ICollection<tblTaxType> tblTaxTypes { get; set; }
        public virtual ICollection<tblTermCCE> tblTermCCEs { get; set; }
        public virtual ICollection<tblTimeTable> tblTimeTables { get; set; }
        public virtual ICollection<tblTimetable_workingDays> tblTimetable_workingDays { get; set; }
        public virtual ICollection<tblTimeTableDetail> tblTimeTableDetails { get; set; }
        public virtual ICollection<tblTopic> tblTopics { get; set; }
        public virtual ICollection<tblTransportPayment> tblTransportPayments { get; set; }
        public virtual ICollection<tblTransportTripSheet> tblTransportTripSheets { get; set; }
        public virtual ICollection<tblTripParticipant> tblTripParticipants { get; set; }
        public virtual ICollection<tblTripSheet> tblTripSheets { get; set; }
        public virtual ICollection<tblUnitOfMeasure> tblUnitOfMeasures { get; set; }
        public virtual ICollection<tblVehicle> tblVehicles { get; set; }
        public virtual ICollection<tblVehicleType> tblVehicleTypes { get; set; }
        public virtual ICollection<tblVendor> tblVendors { get; set; }
        public virtual ICollection<tblVisitorMaterial> tblVisitorMaterials { get; set; }
        public virtual ICollection<tblVisitor> tblVisitors { get; set; }
        public virtual ICollection<tblVoucherList> tblVoucherLists { get; set; }
    }
}
