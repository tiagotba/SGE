using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Entity
{
   public class DesocupacaoMap : EntityTypeConfiguration<Desocupacao>
    {

        public DesocupacaoMap()
        {
            this.HasKey(d => d.Id_Desocupacao);
            this.Property(d => d.Data_Hora_Saida).HasColumnName("DATA_SAIDA");
            this.HasRequired(o => o.Vaga)
               .WithMany(x => x.Desocupacoes).Map(m => m.MapKey("Id_Vaga"));
            this.HasRequired(v => v.setor)
                    .WithMany(x => x.Desocupacoes)
                    .Map(m => m.MapKey("Id_Setor"));

            this.HasRequired(o => o.Veiculo)
               .WithMany(x => x.Desocupacoes)
              .Map(m => m.MapKey("Id_Veiculo"));

            this.HasRequired(x => x.Estadia)
      .WithRequiredPrincipal();

            this.ToTable("DES_DESOCUPACAO");
        }
    }
}
