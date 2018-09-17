using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Entity
{
  public  class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            this.HasKey(c => c.Id_Cliente);

            this.Property(c => c.Nome_Cliente).HasMaxLength(500);

            this.Property(c => c.Rg_Cliente).HasMaxLength(13);

            this.Property(c => c.Cpf_Cliente).HasMaxLength(18);

            this.Property(c => c.E_Func_Cliente);

            this.ToTable("CLI_CLIENTE", "bd_sge_sql");
        }
    }
}
