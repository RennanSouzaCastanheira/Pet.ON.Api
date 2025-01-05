using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServicePetShop.Domain.Entidade.v1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Infra.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(a => a.IdUsuario);

            builder.HasIndex(a => a.IdAnimal);
            builder.HasIndex(a => a.IdUsuario);

            builder.Property(a => a.IdUsuario)
                .HasColumnName("idUsuario")
                .HasColumnType("INT");

            builder.Property(a => a.IdAnimal)
                .HasColumnName("idAnimal")
                .HasColumnType("INT");

            builder.Property(a => a.IdEmpresa)
                .HasColumnName("idEmpresa")
                .HasColumnType("INT");

            builder.Property(a => a.Nome)
                .HasColumnName("nome")
                .HasColumnType("VARCHAR(255)");

            builder.Property(a => a.Telefone)
                .HasColumnName("telefone")
                .HasColumnType("VARCHAR(20)");

            builder.Property(a => a.Endereco)
                .HasColumnName("Endereco")
                .HasColumnType("VARCHAR(255)");

            builder.Property(a => a.Geolocalizacao)
                .HasColumnName("Geolocalizacao")
                .HasColumnType("VARCHAR(255)");

            builder.Property(a => a.DataPrimeiroAcesso)
                .HasColumnName("DataPrimeiroAcesso")
                .HasColumnType("DATETIME");

            builder.Property(a => a.Senha)
                .HasColumnName("Senha")
                .HasColumnType("VARCHAR(100)");

            builder.Property(a => a.Email)
                .HasColumnName("Email")
                .HasColumnType("VARCHAR(255)");
        }
    }
}
