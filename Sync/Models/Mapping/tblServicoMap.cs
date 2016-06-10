using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sync.Models.Mapping
{
    public class tblServicoMap : EntityTypeConfiguration<tblServico>
    {
        public tblServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.idServico);

            // Properties
            this.Property(t => t.idServico)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nomeServico)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.DescricaoServico)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("tblServico");
            this.Property(t => t.idServico).HasColumnName("idServico");
            this.Property(t => t.nomeServico).HasColumnName("nomeServico");
            this.Property(t => t.DescricaoServico).HasColumnName("DescricaoServico");
        }
    }
}
