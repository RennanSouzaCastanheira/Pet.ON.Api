using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServicePetShop.Domain.Entidade.v1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Infra.Mapping
{
    public class AnimalMap : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("animal");

            builder.HasKey(a => a.IdAnimal);

            builder.HasIndex(a => a.IdAnimal);

            builder.Property(a => a.IdAnimal)
                .HasColumnName("IdAnimal")
                .HasColumnType("INT(11)");

            builder.Property(a => a.IdUsuario)
                .HasColumnName("IdUsuario")
                .HasColumnType("int");

            builder.Property(a => a.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(255)");

            builder.Property(a => a.Raca)
                .HasColumnName("Raca")
                .HasColumnType("VARCHAR(255)");

            builder.Property(a => a.TipoAnimal)
                .HasColumnName("TipoAnimal")
                .HasColumnType("VARCHAR(255)");

            builder.Property(a => a.Sexo)
                .HasColumnName("Sexo")
                .HasColumnType("char(1)");

        }
    }
}
