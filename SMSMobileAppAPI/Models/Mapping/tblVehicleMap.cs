using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblVehicleMap : EntityTypeConfiguration<tblVehicle>
    {
        public tblVehicleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            this.Property(t => t.ChassisNumber)
                .IsRequired();

            this.Property(t => t.RegistrationNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ContactPerson)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InsuranceNo)
                .IsRequired();

            this.Property(t => t.RCNumber)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("tblVehicle");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ChassisNumber).HasColumnName("ChassisNumber");
            this.Property(t => t.RegistrationNo).HasColumnName("RegistrationNo");
            this.Property(t => t.SeartingCapacity).HasColumnName("SeartingCapacity");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.InsuranceNo).HasColumnName("InsuranceNo");
            this.Property(t => t.InsuranceRenewalDate).HasColumnName("InsuranceRenewalDate");
            this.Property(t => t.RCNumber).HasColumnName("RCNumber");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblVehicles)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblVehicleType)
                .WithMany(t => t.tblVehicles)
                .HasForeignKey(d => d.TypeId);

        }
    }
}
