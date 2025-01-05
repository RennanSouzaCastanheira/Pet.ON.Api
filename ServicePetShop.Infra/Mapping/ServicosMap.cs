using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServicePetShop.Domain.Entidade.v1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Infra.Mapping
{
    public class ServicosMap : IEntityTypeConfiguration<Servicos>
    {
        public void Configure(EntityTypeBuilder<Servicos> builder)
        {
            builder.ToTable("SERVICO");

            builder.HasKey(a => a.IdServico);

            builder.HasIndex(a => a.IdServico);
            builder.HasIndex(a => a.IdEmpresa);

            builder.Property(a => a.IdServico)
                .HasColumnName("IdServico")
                .HasColumnType("INT(11)");

            builder.Property(a => a.IdEmpresa)
                .HasColumnName("IdEmpresa")
                .HasColumnType("INT(11)");

            builder.Property(a => a.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("VARCHAR(255)");

            builder.Property(a => a.Valor)
                .HasColumnName("Valor")
                .HasColumnType("DECIMAL(10,2)");

            builder.Property(a => a.QtdeHora)
                .HasColumnName("QtdeHora")
                .HasColumnType("DECIMAL(2,2)");

            builder.Property(a => a.Observacao)
                .HasColumnName("Observacao")
                .HasColumnType("VARCHAR(255)");

            builder.Property(a => a.Oferta)
                .HasColumnName("Oferta")
                .HasColumnType("BOOLEAN");

            builder.Property(a => a.ValorOferta)
                .HasColumnName("ValorOferta")
                .HasColumnType("DECIMAL(10,2)");

        }
    }
}
