﻿using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Entity
{
  public  class OcorrenciaMap : EntityTypeConfiguration<Ocorrencia>
    {
        public OcorrenciaMap()
        {
            this.HasKey(o => o.Id_Ocorrencia);
            this.Property(o => o.Titulo_Ocorrencia).HasColumnName("TITULO_OCORRENCIA").HasMaxLength(500);
            this.Property(o => o.Desc_Ocorrencia).HasColumnName("DESC_OCORRENCIA");
            this.Property(o => o.Data_Hora_Ocorrencia).HasColumnType("datetime").HasColumnName("DATA_OCORRENCIA");
            this.HasRequired(o => o.TipoOcorrencia)
                .WithMany(x => x.Ocorrencias)
                .Map(m => m.MapKey("Id_Tipo_Ocorrencia"));
            this.HasRequired(o => o.Veiculo)
                .WithMany(x => x.Ocorrencias)
                .Map(m => m.MapKey("Id_Veiculo"));
            this.HasRequired(o => o.Cliente)
               .WithMany(x => x.Ocorrencias)
               .Map(m => m.MapKey("Id_Cliente"));
            this.Property(o => o.Tipo_Status).IsRequired().HasColumnName("FL_STATUS_OCORRENCIA").HasColumnType("bit");

            this.ToTable("OCO_OCORRENCIA");
        }
    }
}
