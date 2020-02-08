using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telefonia.Model.Config
{
    public class PlanoConfiguration : IEntityTypeConfiguration<Plano>
    {
        public void Configure(EntityTypeBuilder<Plano> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CodigoPlano).HasColumnName("codigo_plano").IsRequired();
            builder.Property(p => p.Minutos).HasColumnName("minutos").IsRequired();
            builder.Property(p => p.FranquiaInternet).HasColumnName("franquia_internet").IsRequired();
            builder.Property(p => p.Valor).HasColumnName("valor").IsRequired();
            builder.Property(p => p.Tipo).HasColumnName("tipo").IsRequired();
            builder.Property(p => p.OperadoraId).HasColumnName("operadora_id").IsRequired();
        }

    }
}
