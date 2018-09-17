using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Entity
{
    public class Bd_Sge_Fluent : DbContext
    {
        public Bd_Sge_Fluent() : base("Name=bd_sge_sql")
        {

        }

        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Setor> setor { get; set; }
        public DbSet<Vagas> vagas { get; set; }
        public DbSet<Veiculo> veiculos { get; set; }
        public DbSet<Ocupacao> ocupacao { get; set; }
        public DbSet<Ocorrencia> ocorrencia { get; set; }
        public DbSet<Desocupacao> desocupacao { get; set; }
        public DbSet<TipoOcorrencia> tipo_ocorrencia { get; set; }
        public DbSet<Estadia> estadia { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new OcupacaoMap());
            modelBuilder.Configurations.Add(new DesocupacaoMap());
            modelBuilder.Configurations.Add(new SetorMap());
            modelBuilder.Configurations.Add(new VagasMap());
            modelBuilder.Configurations.Add(new OcorrenciaMap());
            modelBuilder.Configurations.Add(new TipoOcorrenciaMap());
            modelBuilder.Configurations.Add(new VeiculoMap());
            modelBuilder.Configurations.Add(new EstadiaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }

    }
}
