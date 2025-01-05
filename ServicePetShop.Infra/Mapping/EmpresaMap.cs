using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServicePetShop.Domain.Entidade.v1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Infra.Mapping
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("EMPRESA");

            builder.HasKey(a => a.IdEmpresa);

            builder.HasIndex(a => a.IdEmpresa);

            builder.Property(a => a.IdEmpresa)
                .HasColumnName("IdEmpresa")
                .HasColumnType("INT(11)");

            builder.Property(a => a.DescricaoNomeFisica)
                .HasColumnName("DescricaoNomeFisica")
                .HasColumnType("VARCHAR(255)");

            builder.Property(a => a.CPFCNPJ)
                .HasColumnName("CPFCNPJ")
                .HasColumnType("VARCHAR(30)");

            builder.Property(a => a.Apelido)
                .HasColumnName("Apelido")
                .HasColumnType("VARCHAR(50)");

            builder.Property(a => a.FisicaJuridica)
                .HasColumnName("FisicaJuridica")
                .HasColumnType("VARCHAR(1)");

            builder.Property(a => a.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("VARCHAR(30)");


        }
    }

}