using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telefonia.Model.Config
{
    public class PlanoDDDConfiguration : IEntityTypeConfiguration<PlanoDDD>
    {
        public void Configure(EntityTypeBuilder<PlanoDDD> builder)
        {
            builder.HasKey(p => new { p.PlanoId, p.DDDId});
            builder.Property(p => p.DDDId).HasColumnName("ddd_id").IsRequired();
            builder.Property(p => p.PlanoId).HasColumnName("plano_id").IsRequired();
        }
    }
}
