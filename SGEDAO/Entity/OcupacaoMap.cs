using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Entity
{
  public  class OcupacaoMap : EntityTypeConfiguration<Ocupacao>
    {
        public OcupacaoMap()
        {
            this.HasKey(o => o.Id_Ocup);

            this.Property(o => o.Data_Hora_Entrada).HasColumnName("DATA_ENTRADA") ;

            this.HasRequired(o => o.setor).WithMany(o => o.Ocupacoes);

            this.HasRequired(o => o.vaga).WithMany(o => o.Ocupacoes);

            this.HasRequired(o => o.veiculo).WithMany(o => o.Ocupacoes);
        }
    }
}
