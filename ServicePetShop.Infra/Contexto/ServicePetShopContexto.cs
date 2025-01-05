using Microsoft.EntityFrameworkCore;
using ServicePetShop.Domain.Entidade.v1;
using ServicePetShop.Infra.Mapping;

namespace ServicePetShop.Infra.Contexto
{
    public class ServicePetShopContexto : DbContext
    {

        #region Ctor
        public ServicePetShopContexto(DbContextOptions<ServicePetShopContexto> options) : base(options)
        {
            Database.Migrate();
        }
        #endregion

        //public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Empresa> Empresa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AgendamentoMap());
            modelBuilder.ApplyConfiguration(new AnimalMap());
            modelBuilder.ApplyConfiguration(new ServicosMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new EmpresaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
