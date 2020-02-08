using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telefonia.Model.Config
{
    public class OperadoraConfiguration : IEntityTypeConfiguration<Operadora>
    {
        public void Configure(EntityTypeBuilder<Operadora> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Nome).HasMaxLength(30).IsRequired().HasColumnName("nome");
        }
    }
}
