using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblGlobalOrgSettingMap : EntityTypeConfiguration<tblGlobalOrgSetting>
    {
        public tblGlobalOrgSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TermsAndConditionPayment)
                .HasMaxLength(2000);

            this.Property(t => t.BirthdayEmailContent)
                .HasMaxLength(500);

            this.Property(t => t.AnniversaryEmailContent)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblGlobalOrgSettings");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MandatoryFeeOnAdmission).HasColumnName("MandatoryFeeOnAdmission");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.FeePaymentSchedule).HasColumnName("FeePaymentSchedule");
            this.Property(t => t.TimeZone).HasColumnName("TimeZone");
            this.Property(t => t.BarcodeType).HasColumnName("BarcodeType");
            this.Property(t => t.HeaderHTML).HasColumnName("HeaderHTML");
            this.Property(t => t.FooterHTML).HasColumnName("FooterHTML");
            this.Property(t => t.TermsAndConditionPayment).HasColumnName("TermsAndConditionPayment");
            this.Property(t => t.BirthdayEmailContent).HasColumnName("BirthdayEmailContent");
            this.Property(t => t.AnniversaryEmailContent).HasColumnName("AnniversaryEmailContent");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblBarCodeSymbology)
                .WithMany(t => t.tblGlobalOrgSettings)
                .HasForeignKey(d => d.BarcodeType);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblGlobalOrgSettings)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
