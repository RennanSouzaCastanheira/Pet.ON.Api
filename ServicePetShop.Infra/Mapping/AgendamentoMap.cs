using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServicePetShop.Domain.Entidade.v1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Infra.Mapping
{
    public class AgendamentoMap : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("AGENDAMENTO");

            builder.HasKey(a => a.Controle);

            builder.HasIndex(a => new { a.Controle,a.IdAgendamento,a.IdServico,a.IdAnimal,a.IdUsuario });

            builder.Property(a => a.Controle)
                .HasColumnName("Controle")
                .HasColumnType("INT(11)");

            builder.Property(a => a.IdAgendamento)
                .HasColumnName("IdAgendamento")
                .HasColumnType("INT(11)");

            builder.Property(a => a.IdServico)
                .HasColumnName("IdServico")
                .HasColumnType("INT(11)");

            builder.HasOne(e => e.Servico)
                     .WithMany()
                     .HasForeignKey(f => f.IdServico);

            builder.Property(a => a.IdAnimal)
                .HasColumnName("IdAnimal")
                .HasColumnType("INT(11)");

            builder.HasOne(e => e.Animal)
                     .WithMany()
                     .HasForeignKey(f => f.IdAnimal);

            builder.Property(a => a.IdUsuario)
                .HasColumnName("IdUsuario")
                .HasColumnType("INT(11)");

            builder.HasOne(e => e.Usuario)
                     .WithMany()
                     .HasForeignKey(f => f.IdUsuario);

            builder.Property(a => a.IdEmpresa)
                .HasColumnName("IdEmpresa")
                .HasColumnType("INT(11)");
        
            builder.Property(a => a.DataHoraAgendamento)
                .HasColumnName("DataHoraAgendamento")
                .HasColumnType("DATETIME");

            builder.Property(a => a.Status)
                .HasColumnName("Status")
                .HasColumnType("VARCHAR(3)");

            //builder.HasOne(e => e.Empresa)
            //         .WithMany()
            //         .HasForeignKey(f => f.IdEmpresa);

        }
    }
}