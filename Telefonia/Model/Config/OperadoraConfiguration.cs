using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telefonia.Model.Config
{
    public class OperadoraConfiguration : IEntityTypeConfiguration<Operadora>
    {
        public void Configure(EntityTypeBuilder<Operadora> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
