using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SMSMobileAppAPI.Models.Mapping;

namespace SMSMobileAppAPI.Models
{
    public partial class webSchoolContext : DbContext
    {
        static webSchoolContext()
        {
            Database.SetInitializer<webSchoolContext>(null);
        }

        public webSchoolContext()
            : base("Name=webSchoolContext")
        {
        }

        public DbSet<CounsellorNote> CounsellorNotes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tblAccountGroup> tblAccountGroups { get; set; }
        public DbSet<tblAccountLedger> tblAccountLedgers { get; set; }
        public DbSet<tblAdmissionStatusType> tblAdmissionStatusTypes { get; set; }
        public DbSet<tblAffiliation> tblAffiliations { get; set; }
        public DbSet<tblApplicationLog> tblApplicationLogs { get; set; }
        public DbSet<tblAppLogin> tblAppLogins { get; set; }
        public DbSet<tblAppVersion> tblAppVersions { get; set; }
        public DbSet<tblAssetAttribute> tblAssetAttributes { get; set; }
        public DbSet<tblAssetCategory> tblAssetCategories { get; set; }
        public DbSet<tblAssetCategoryAttribute> tblAssetCategoryAttributes { get; set; }
        public DbSet<tblAsset> tblAssets { get; set; }
        public DbSet<tblAssignment> tblAssignments { get; set; }
        public DbSet<tblAssignmentQuestion> tblAssignmentQuestions { get; set; }
        public DbSet<tblAttendance> tblAttendances { get; set; }
        public DbSet<tblAttendanceHourly> tblAttendanceHourlies { get; set; }
        public DbSet<tblAttributeType> tblAttributeTypes { get; set; }
        public DbSet<tblBankDetail> tblBankDetails { get; set; }
        public DbSet<tblBarCodeSymbology> tblBarCodeSymbologies { get; set; }
        public DbSet<tblBatch> tblBatches { get; set; }
        public DbSet<tblBatchAdmission> tblBatchAdmissions { get; set; }
        public DbSet<tblBatchAdmissionArchive> tblBatchAdmissionArchives { get; set; }
        public DbSet<tblBatchAdmissionPast> tblBatchAdmissionPasts { get; set; }
        public DbSet<tblBlockAttributesCCE> tblBlockAttributesCCEs { get; set; }
        public DbSet<tblBlockCCE> tblBlockCCEs { get; set; }
        public DbSet<tblBranch> tblBranches { get; set; }
        public DbSet<tblCaste> tblCastes { get; set; }
        public DbSet<tblCertificate> tblCertificates { get; set; }
        public DbSet<tblChallan_InvoiceDetail> tblChallan_InvoiceDetail { get; set; }
        public DbSet<tblChallan_InvoiceHeader> tblChallan_InvoiceHeader { get; set; }
        public DbSet<tblCircular> tblCirculars { get; set; }
        public DbSet<tblCounsellor> tblCounsellors { get; set; }
        public DbSet<tblCourse> tblCourses { get; set; }
        public DbSet<tblCourse_Subject> tblCourse_Subject { get; set; }
        public DbSet<tblCourseFeeDetail> tblCourseFeeDetails { get; set; }
        public DbSet<tblCustomer> tblCustomers { get; set; }
        public DbSet<tblDatabaseLog> tblDatabaseLogs { get; set; }
        public DbSet<tblDepartment> tblDepartments { get; set; }
        public DbSet<tblDesignation> tblDesignations { get; set; }
        public DbSet<tblDietaryItem> tblDietaryItems { get; set; }
        public DbSet<tblDietPlan> tblDietPlans { get; set; }
        public DbSet<tblDietPlanDetail> tblDietPlanDetails { get; set; }
        public DbSet<tblDiscountType> tblDiscountTypes { get; set; }
        public DbSet<tblDriver> tblDrivers { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<tblEmployeeAdditionalInfo> tblEmployeeAdditionalInfoes { get; set; }
        public DbSet<tblEmployeeAttachment> tblEmployeeAttachments { get; set; }
        public DbSet<tblEmployeeAttendance> tblEmployeeAttendances { get; set; }
        public DbSet<tblEmployeeLeaveType> tblEmployeeLeaveTypes { get; set; }
        public DbSet<tblEmployeeSalaryComponent> tblEmployeeSalaryComponents { get; set; }
        public DbSet<tblEmpSalaryDetail> tblEmpSalaryDetails { get; set; }
        public DbSet<tblEvent> tblEvents { get; set; }
        public DbSet<tblEventType> tblEventTypes { get; set; }
        public DbSet<tblExamHall> tblExamHalls { get; set; }
        public DbSet<tblExamMark> tblExamMarks { get; set; }
        public DbSet<tblExamSchedule> tblExamSchedules { get; set; }
        public DbSet<tblExamType> tblExamTypes { get; set; }
        public DbSet<tblFeeInstallmentDetail> tblFeeInstallmentDetails { get; set; }
        public DbSet<tblFeeItemDetail> tblFeeItemDetails { get; set; }
        public DbSet<tblFeeLedgerGroup> tblFeeLedgerGroups { get; set; }
        public DbSet<tblFeePaidDetail> tblFeePaidDetails { get; set; }
        public DbSet<tblFeePaymentMode> tblFeePaymentModes { get; set; }
        public DbSet<tblFormativeAssessmentCCE> tblFormativeAssessmentCCEs { get; set; }
        public DbSet<tblGlobalOrgSetting> tblGlobalOrgSettings { get; set; }
        public DbSet<tblGPSData> tblGPSDatas { get; set; }
        public DbSet<tblGRN_Direct_Detail> tblGRN_Direct_Detail { get; set; }
        public DbSet<tblGRN_Direct_Header> tblGRN_Direct_Header { get; set; }
        public DbSet<tblGRN_PO_Detail> tblGRN_PO_Detail { get; set; }
        public DbSet<tblGRN_PO_Header> tblGRN_PO_Header { get; set; }
        public DbSet<tblHolidayList> tblHolidayLists { get; set; }
        public DbSet<tblHostel> tblHostels { get; set; }
        public DbSet<tblHostel_Room> tblHostel_Room { get; set; }
        public DbSet<tblHostel_Room_Student> tblHostel_Room_Student { get; set; }
        public DbSet<tblHostelBilling> tblHostelBillings { get; set; }
        public DbSet<tblHostelRoom> tblHostelRooms { get; set; }
        public DbSet<tblHostelType> tblHostelTypes { get; set; }
        public DbSet<tblImageGallery> tblImageGalleries { get; set; }
        public DbSet<tblInstitution> tblInstitutions { get; set; }
        public DbSet<tblIssueList> tblIssueLists { get; set; }
        public DbSet<tblItem_Vendor> tblItem_Vendor { get; set; }
        public DbSet<tblItemCategory> tblItemCategories { get; set; }
        public DbSet<tblItem> tblItems { get; set; }
        public DbSet<tblLeadFollowUp> tblLeadFollowUps { get; set; }
        public DbSet<tblLeadStatu> tblLeadStatus { get; set; }
        public DbSet<tblLearnoMeterCCE> tblLearnoMeterCCEs { get; set; }
        public DbSet<tblLibrary> tblLibraries { get; set; }
        public DbSet<tblLibraryBook> tblLibraryBooks { get; set; }
        public DbSet<tblLibraryBookAuthor> tblLibraryBookAuthors { get; set; }
        public DbSet<tblLibraryBookCategory> tblLibraryBookCategories { get; set; }
        public DbSet<tblLibraryBookEdition> tblLibraryBookEditions { get; set; }
        public DbSet<tblLibraryBookLedger> tblLibraryBookLedgers { get; set; }
        public DbSet<tblLibraryBookPublication> tblLibraryBookPublications { get; set; }
        public DbSet<tblLibraryBookVolume> tblLibraryBookVolumes { get; set; }
        public DbSet<tblLogin> tblLogins { get; set; }
        public DbSet<tblLoginUserType> tblLoginUserTypes { get; set; }
        public DbSet<tblMasterAccountGroup> tblMasterAccountGroups { get; set; }
        public DbSet<tblMasterPermissionSet> tblMasterPermissionSets { get; set; }
        public DbSet<tblMasterVoucherList> tblMasterVoucherLists { get; set; }
        public DbSet<tblMedicineDetail> tblMedicineDetails { get; set; }
        public DbSet<tblMessageAttachment> tblMessageAttachments { get; set; }
        public DbSet<tblMessageCenter> tblMessageCenters { get; set; }
        public DbSet<tblMessageRecipient> tblMessageRecipients { get; set; }
        public DbSet<tblNationality> tblNationalities { get; set; }
        public DbSet<tblOrg> tblOrgs { get; set; }
        public DbSet<tblPayGroup> tblPayGroups { get; set; }
        public DbSet<tblPayGroupDetail> tblPayGroupDetails { get; set; }
        public DbSet<tblPayroll> tblPayrolls { get; set; }
        public DbSet<tblPayrollDetail> tblPayrollDetails { get; set; }
        public DbSet<tblPermissionValueDetail> tblPermissionValueDetails { get; set; }
        public DbSet<tblProforma_InvoiceDetail> tblProforma_InvoiceDetail { get; set; }
        public DbSet<tblProforma_InvoiceHeader> tblProforma_InvoiceHeader { get; set; }
        public DbSet<tblProforma_ServiceInvoiceDetail> tblProforma_ServiceInvoiceDetail { get; set; }
        public DbSet<tblProforma_ServiceInvoiceHeader> tblProforma_ServiceInvoiceHeader { get; set; }
        public DbSet<tblProforma_TaxInvoiceHeader> tblProforma_TaxInvoiceHeader { get; set; }
        public DbSet<tblPurchaseOrderDetail> tblPurchaseOrderDetails { get; set; }
        public DbSet<tblPurchaseOrderHeader> tblPurchaseOrderHeaders { get; set; }
        public DbSet<tblQuestionBank> tblQuestionBanks { get; set; }
        public DbSet<tblRetail_InvoiceDetail> tblRetail_InvoiceDetail { get; set; }
        public DbSet<tblRetail_InvoiceHeader> tblRetail_InvoiceHeader { get; set; }
        public DbSet<tblRole> tblRoles { get; set; }
        public DbSet<tblRolePermission> tblRolePermissions { get; set; }
        public DbSet<tblRoute> tblRoutes { get; set; }
        public DbSet<tblRoute_Stops> tblRoute_Stops { get; set; }
        public DbSet<tblRoute_Vehicle> tblRoute_Vehicle { get; set; }
        public DbSet<tblRouteStop> tblRouteStops { get; set; }
        public DbSet<tblService_InvoiceDetail> tblService_InvoiceDetail { get; set; }
        public DbSet<tblService_InvoiceHeader> tblService_InvoiceHeader { get; set; }
        public DbSet<tblStockGroup> tblStockGroups { get; set; }
        public DbSet<tblStockItem> tblStockItems { get; set; }
        public DbSet<tblStream> tblStreams { get; set; }
        public DbSet<tblStudent> tblStudents { get; set; }
        public DbSet<tblStudent_Course> tblStudent_Course { get; set; }
        public DbSet<tblStudentAttachment> tblStudentAttachments { get; set; }
        public DbSet<tblStudentCategory> tblStudentCategories { get; set; }
        public DbSet<tblStudentCustomize> tblStudentCustomizes { get; set; }
        public DbSet<tblStudentCustomizeValue> tblStudentCustomizeValues { get; set; }
        public DbSet<tblStudentFeePaidHeader> tblStudentFeePaidHeaders { get; set; }
        public DbSet<tblStudentMedicine> tblStudentMedicines { get; set; }
        public DbSet<tblStudentPrevQualificationReason> tblStudentPrevQualificationReasons { get; set; }
        public DbSet<tblStudentQualification> tblStudentQualifications { get; set; }
        public DbSet<tblStudentRegistration> tblStudentRegistrations { get; set; }
        public DbSet<tblStudentResultsCCE> tblStudentResultsCCEs { get; set; }
        public DbSet<tblStudentValue> tblStudentValues { get; set; }
        public DbSet<tblSubBlockCCE> tblSubBlockCCEs { get; set; }
        public DbSet<tblSubCaste> tblSubCastes { get; set; }
        public DbSet<tblSubject> tblSubjects { get; set; }
        public DbSet<tblSummativeAssessmentCCE> tblSummativeAssessmentCCEs { get; set; }
        public DbSet<tblTax_InvoiceDetail> tblTax_InvoiceDetail { get; set; }
        public DbSet<tblTax_InvoiceHeader> tblTax_InvoiceHeader { get; set; }
        public DbSet<tblTaxDetail> tblTaxDetails { get; set; }
        public DbSet<tblTaxType> tblTaxTypes { get; set; }
        public DbSet<tblTermCCE> tblTermCCEs { get; set; }
        public DbSet<tblTimeTable> tblTimeTables { get; set; }
        public DbSet<tblTimetable_workingDays> tblTimetable_workingDays { get; set; }
        public DbSet<tblTimeTableDetail> tblTimeTableDetails { get; set; }
        public DbSet<tblTopic> tblTopics { get; set; }
        public DbSet<tblTransportPayment> tblTransportPayments { get; set; }
        public DbSet<tblTransportTripSheet> tblTransportTripSheets { get; set; }
        public DbSet<tblTripParticipant> tblTripParticipants { get; set; }
        public DbSet<tblTripSheet> tblTripSheets { get; set; }
        public DbSet<tblUnitOfMeasure> tblUnitOfMeasures { get; set; }
        public DbSet<tblVehicle> tblVehicles { get; set; }
        public DbSet<tblVehicleType> tblVehicleTypes { get; set; }
        public DbSet<tblVendor> tblVendors { get; set; }
        public DbSet<tblVisitorMaterial> tblVisitorMaterials { get; set; }
        public DbSet<tblVisitor> tblVisitors { get; set; }
        public DbSet<tblVoucherList> tblVoucherLists { get; set; }
        public DbSet<View> Views { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CounsellorNoteMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new tblAccountGroupMap());
            modelBuilder.Configurations.Add(new tblAccountLedgerMap());
            modelBuilder.Configurations.Add(new tblAdmissionStatusTypeMap());
            modelBuilder.Configurations.Add(new tblAffiliationMap());
            modelBuilder.Configurations.Add(new tblApplicationLogMap());
            modelBuilder.Configurations.Add(new tblAppLoginMap());
            modelBuilder.Configurations.Add(new tblAppVersionMap());
            modelBuilder.Configurations.Add(new tblAssetAttributeMap());
            modelBuilder.Configurations.Add(new tblAssetCategoryMap());
            modelBuilder.Configurations.Add(new tblAssetCategoryAttributeMap());
            modelBuilder.Configurations.Add(new tblAssetMap());
            modelBuilder.Configurations.Add(new tblAssignmentMap());
            modelBuilder.Configurations.Add(new tblAssignmentQuestionMap());
            modelBuilder.Configurations.Add(new tblAttendanceMap());
            modelBuilder.Configurations.Add(new tblAttendanceHourlyMap());
            modelBuilder.Configurations.Add(new tblAttributeTypeMap());
            modelBuilder.Configurations.Add(new tblBankDetailMap());
            modelBuilder.Configurations.Add(new tblBarCodeSymbologyMap());
            modelBuilder.Configurations.Add(new tblBatchMap());
            modelBuilder.Configurations.Add(new tblBatchAdmissionMap());
            modelBuilder.Configurations.Add(new tblBatchAdmissionArchiveMap());
            modelBuilder.Configurations.Add(new tblBatchAdmissionPastMap());
            modelBuilder.Configurations.Add(new tblBlockAttributesCCEMap());
            modelBuilder.Configurations.Add(new tblBlockCCEMap());
            modelBuilder.Configurations.Add(new tblBranchMap());
            modelBuilder.Configurations.Add(new tblCasteMap());
            modelBuilder.Configurations.Add(new tblCertificateMap());
            modelBuilder.Configurations.Add(new tblChallan_InvoiceDetailMap());
            modelBuilder.Configurations.Add(new tblChallan_InvoiceHeaderMap());
            modelBuilder.Configurations.Add(new tblCircularMap());
            modelBuilder.Configurations.Add(new tblCounsellorMap());
            modelBuilder.Configurations.Add(new tblCourseMap());
            modelBuilder.Configurations.Add(new tblCourse_SubjectMap());
            modelBuilder.Configurations.Add(new tblCourseFeeDetailMap());
            modelBuilder.Configurations.Add(new tblCustomerMap());
            modelBuilder.Configurations.Add(new tblDatabaseLogMap());
            modelBuilder.Configurations.Add(new tblDepartmentMap());
            modelBuilder.Configurations.Add(new tblDesignationMap());
            modelBuilder.Configurations.Add(new tblDietaryItemMap());
            modelBuilder.Configurations.Add(new tblDietPlanMap());
            modelBuilder.Configurations.Add(new tblDietPlanDetailMap());
            modelBuilder.Configurations.Add(new tblDiscountTypeMap());
            modelBuilder.Configurations.Add(new tblDriverMap());
            modelBuilder.Configurations.Add(new tblEmployeeMap());
            modelBuilder.Configurations.Add(new tblEmployeeAdditionalInfoMap());
            modelBuilder.Configurations.Add(new tblEmployeeAttachmentMap());
            modelBuilder.Configurations.Add(new tblEmployeeAttendanceMap());
            modelBuilder.Configurations.Add(new tblEmployeeLeaveTypeMap());
            modelBuilder.Configurations.Add(new tblEmployeeSalaryComponentMap());
            modelBuilder.Configurations.Add(new tblEmpSalaryDetailMap());
            modelBuilder.Configurations.Add(new tblEventMap());
            modelBuilder.Configurations.Add(new tblEventTypeMap());
            modelBuilder.Configurations.Add(new tblExamHallMap());
            modelBuilder.Configurations.Add(new tblExamMarkMap());
            modelBuilder.Configurations.Add(new tblExamScheduleMap());
            modelBuilder.Configurations.Add(new tblExamTypeMap());
            modelBuilder.Configurations.Add(new tblFeeInstallmentDetailMap());
            modelBuilder.Configurations.Add(new tblFeeItemDetailMap());
            modelBuilder.Configurations.Add(new tblFeeLedgerGroupMap());
            modelBuilder.Configurations.Add(new tblFeePaidDetailMap());
            modelBuilder.Configurations.Add(new tblFeePaymentModeMap());
            modelBuilder.Configurations.Add(new tblFormativeAssessmentCCEMap());
            modelBuilder.Configurations.Add(new tblGlobalOrgSettingMap());
            modelBuilder.Configurations.Add(new tblGPSDataMap());
            modelBuilder.Configurations.Add(new tblGRN_Direct_DetailMap());
            modelBuilder.Configurations.Add(new tblGRN_Direct_HeaderMap());
            modelBuilder.Configurations.Add(new tblGRN_PO_DetailMap());
            modelBuilder.Configurations.Add(new tblGRN_PO_HeaderMap());
            modelBuilder.Configurations.Add(new tblHolidayListMap());
            modelBuilder.Configurations.Add(new tblHostelMap());
            modelBuilder.Configurations.Add(new tblHostel_RoomMap());
            modelBuilder.Configurations.Add(new tblHostel_Room_StudentMap());
            modelBuilder.Configurations.Add(new tblHostelBillingMap());
            modelBuilder.Configurations.Add(new tblHostelRoomMap());
            modelBuilder.Configurations.Add(new tblHostelTypeMap());
            modelBuilder.Configurations.Add(new tblImageGalleryMap());
            modelBuilder.Configurations.Add(new tblInstitutionMap());
            modelBuilder.Configurations.Add(new tblIssueListMap());
            modelBuilder.Configurations.Add(new tblItem_VendorMap());
            modelBuilder.Configurations.Add(new tblItemCategoryMap());
            modelBuilder.Configurations.Add(new tblItemMap());
            modelBuilder.Configurations.Add(new tblLeadFollowUpMap());
            modelBuilder.Configurations.Add(new tblLeadStatuMap());
            modelBuilder.Configurations.Add(new tblLearnoMeterCCEMap());
            modelBuilder.Configurations.Add(new tblLibraryMap());
            modelBuilder.Configurations.Add(new tblLibraryBookMap());
            modelBuilder.Configurations.Add(new tblLibraryBookAuthorMap());
            modelBuilder.Configurations.Add(new tblLibraryBookCategoryMap());
            modelBuilder.Configurations.Add(new tblLibraryBookEditionMap());
            modelBuilder.Configurations.Add(new tblLibraryBookLedgerMap());
            modelBuilder.Configurations.Add(new tblLibraryBookPublicationMap());
            modelBuilder.Configurations.Add(new tblLibraryBookVolumeMap());
            modelBuilder.Configurations.Add(new tblLoginMap());
            modelBuilder.Configurations.Add(new tblLoginUserTypeMap());
            modelBuilder.Configurations.Add(new tblMasterAccountGroupMap());
            modelBuilder.Configurations.Add(new tblMasterPermissionSetMap());
            modelBuilder.Configurations.Add(new tblMasterVoucherListMap());
            modelBuilder.Configurations.Add(new tblMedicineDetailMap());
            modelBuilder.Configurations.Add(new tblMessageAttachmentMap());
            modelBuilder.Configurations.Add(new tblMessageCenterMap());
            modelBuilder.Configurations.Add(new tblMessageRecipientMap());
            modelBuilder.Configurations.Add(new tblNationalityMap());
            modelBuilder.Configurations.Add(new tblOrgMap());
            modelBuilder.Configurations.Add(new tblPayGroupMap());
            modelBuilder.Configurations.Add(new tblPayGroupDetailMap());
            modelBuilder.Configurations.Add(new tblPayrollMap());
            modelBuilder.Configurations.Add(new tblPayrollDetailMap());
            modelBuilder.Configurations.Add(new tblPermissionValueDetailMap());
            modelBuilder.Configurations.Add(new tblProforma_InvoiceDetailMap());
            modelBuilder.Configurations.Add(new tblProforma_InvoiceHeaderMap());
            modelBuilder.Configurations.Add(new tblProforma_ServiceInvoiceDetailMap());
            modelBuilder.Configurations.Add(new tblProforma_ServiceInvoiceHeaderMap());
            modelBuilder.Configurations.Add(new tblProforma_TaxInvoiceHeaderMap());
            modelBuilder.Configurations.Add(new tblPurchaseOrderDetailMap());
            modelBuilder.Configurations.Add(new tblPurchaseOrderHeaderMap());
            modelBuilder.Configurations.Add(new tblQuestionBankMap());
            modelBuilder.Configurations.Add(new tblRetail_InvoiceDetailMap());
            modelBuilder.Configurations.Add(new tblRetail_InvoiceHeaderMap());
            modelBuilder.Configurations.Add(new tblRoleMap());
            modelBuilder.Configurations.Add(new tblRolePermissionMap());
            modelBuilder.Configurations.Add(new tblRouteMap());
            modelBuilder.Configurations.Add(new tblRoute_StopsMap());
            modelBuilder.Configurations.Add(new tblRoute_VehicleMap());
            modelBuilder.Configurations.Add(new tblRouteStopMap());
            modelBuilder.Configurations.Add(new tblService_InvoiceDetailMap());
            modelBuilder.Configurations.Add(new tblService_InvoiceHeaderMap());
            modelBuilder.Configurations.Add(new tblStockGroupMap());
            modelBuilder.Configurations.Add(new tblStockItemMap());
            modelBuilder.Configurations.Add(new tblStreamMap());
            modelBuilder.Configurations.Add(new tblStudentMap());
            modelBuilder.Configurations.Add(new tblStudent_CourseMap());
            modelBuilder.Configurations.Add(new tblStudentAttachmentMap());
            modelBuilder.Configurations.Add(new tblStudentCategoryMap());
            modelBuilder.Configurations.Add(new tblStudentCustomizeMap());
            modelBuilder.Configurations.Add(new tblStudentCustomizeValueMap());
            modelBuilder.Configurations.Add(new tblStudentFeePaidHeaderMap());
            modelBuilder.Configurations.Add(new tblStudentMedicineMap());
            modelBuilder.Configurations.Add(new tblStudentPrevQualificationReasonMap());
            modelBuilder.Configurations.Add(new tblStudentQualificationMap());
            modelBuilder.Configurations.Add(new tblStudentRegistrationMap());
            modelBuilder.Configurations.Add(new tblStudentResultsCCEMap());
            modelBuilder.Configurations.Add(new tblStudentValueMap());
            modelBuilder.Configurations.Add(new tblSubBlockCCEMap());
            modelBuilder.Configurations.Add(new tblSubCasteMap());
            modelBuilder.Configurations.Add(new tblSubjectMap());
            modelBuilder.Configurations.Add(new tblSummativeAssessmentCCEMap());
            modelBuilder.Configurations.Add(new tblTax_InvoiceDetailMap());
            modelBuilder.Configurations.Add(new tblTax_InvoiceHeaderMap());
            modelBuilder.Configurations.Add(new tblTaxDetailMap());
            modelBuilder.Configurations.Add(new tblTaxTypeMap());
            modelBuilder.Configurations.Add(new tblTermCCEMap());
            modelBuilder.Configurations.Add(new tblTimeTableMap());
            modelBuilder.Configurations.Add(new tblTimetable_workingDaysMap());
            modelBuilder.Configurations.Add(new tblTimeTableDetailMap());
            modelBuilder.Configurations.Add(new tblTopicMap());
            modelBuilder.Configurations.Add(new tblTransportPaymentMap());
            modelBuilder.Configurations.Add(new tblTransportTripSheetMap());
            modelBuilder.Configurations.Add(new tblTripParticipantMap());
            modelBuilder.Configurations.Add(new tblTripSheetMap());
            modelBuilder.Configurations.Add(new tblUnitOfMeasureMap());
            modelBuilder.Configurations.Add(new tblVehicleMap());
            modelBuilder.Configurations.Add(new tblVehicleTypeMap());
            modelBuilder.Configurations.Add(new tblVendorMap());
            modelBuilder.Configurations.Add(new tblVisitorMaterialMap());
            modelBuilder.Configurations.Add(new tblVisitorMap());
            modelBuilder.Configurations.Add(new tblVoucherListMap());
            modelBuilder.Configurations.Add(new ViewMap());
        }
    }
}
