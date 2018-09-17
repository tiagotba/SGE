using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Entity
{
  public class EstadiaMap : EntityTypeConfiguration<Estadia>
    {
        public EstadiaMap()
        {
            this.HasKey(e => e.Id_Estadia);
            this.Property(e => e.Qtd_Ocorrencia).HasColumnName("QTD_OCORRENCIA");
            this.Property(e=>e.Valor_Estadia).HasColumnName("VLR_ESTADIA").HasColumnType("decimal");
           this. HasOptional(e => e.Ocupacao)
                .WithRequired(x => x.Estadia);
            this.HasOptional(e => e.Desocupacao)
               .WithRequired(x => x.Estadia);
        }
    }
}
