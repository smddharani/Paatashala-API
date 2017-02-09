using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStockItemMap : EntityTypeConfiguration<tblStockItem>
    {
        public tblStockItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblStockItem");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UnitOfMeasure).HasColumnName("UnitOfMeasure");
            this.Property(t => t.StockGroup).HasColumnName("StockGroup");
            this.Property(t => t.OpeningStock).HasColumnName("OpeningStock");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStockItems)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblStockGroup)
                .WithMany(t => t.tblStockItems)
                .HasForeignKey(d => d.StockGroup);
            this.HasOptional(t => t.tblUnitOfMeasure)
                .WithMany(t => t.tblStockItems)
                .HasForeignKey(d => d.UnitOfMeasure);

        }
    }
}
