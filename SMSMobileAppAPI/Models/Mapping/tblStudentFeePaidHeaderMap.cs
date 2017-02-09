using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStudentFeePaidHeaderMap : EntityTypeConfiguration<tblStudentFeePaidHeader>
    {
        public tblStudentFeePaidHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PaidForPeriod)
                .HasMaxLength(50);

            this.Property(t => t.PaymentDetails)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblStudentFeePaidHeader");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.DatePaid).HasColumnName("DatePaid");
            this.Property(t => t.PaidForPeriod).HasColumnName("PaidForPeriod");
            this.Property(t => t.Course).HasColumnName("Course");
            this.Property(t => t.Batch).HasColumnName("Batch");
            this.Property(t => t.GrandTotal).HasColumnName("GrandTotal");
            this.Property(t => t.PaymentMode).HasColumnName("PaymentMode");
            this.Property(t => t.PaymentDetails).HasColumnName("PaymentDetails");
            this.Property(t => t.Bank).HasColumnName("Bank");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblBankDetail)
                .WithMany(t => t.tblStudentFeePaidHeaders)
                .HasForeignKey(d => d.Bank);
            this.HasOptional(t => t.tblFeePaymentMode)
                .WithMany(t => t.tblStudentFeePaidHeaders)
                .HasForeignKey(d => d.PaymentMode);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStudentFeePaidHeaders)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblStudent)
                .WithMany(t => t.tblStudentFeePaidHeaders)
                .HasForeignKey(d => d.StudentId);

        }
    }
}
