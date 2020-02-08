using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telefonia.Model.Config
{
    public class DDDConfiguration : IEntityTypeConfiguration<DDD>
    {
        public void Configure(EntityTypeBuilder<DDD> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.CodigoDDD).HasColumnName("codigo_ddd");
        }
    }
}
