using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Entity
{
  public  class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            this.HasKey(u => u.Id_Usuario);
            this.Property(u => u.Login_Func).IsRequired().HasColumnName("LOGIN_USU");
            this.Property(u => u.Matr_Func).IsRequired().HasColumnName("MATR_USU");
            this.Property(u => u.Tel_Func).IsRequired().HasColumnName("TEL_USU");
            this.Property(u => u.Senha_Func).IsRequired().HasColumnName("SENHA_USU");
            HasOptional(u => u.Cliente)
               .WithRequired(x => x.Usuario);

            this.ToTable("USU_USUARIO", "bd_sge_sql");
        }
    }
}
