﻿using SGEDOMINIO;
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
               .WithMany(x => x.Desocupacoes)
               .HasForeignKey(o => o.Id_Vaga);
            this.HasRequired(o => o.Veiculo)
               .WithMany(x => x.Desocupacoes)
               .HasForeignKey(o => o.Id_Veiculo);
        }
    }
}