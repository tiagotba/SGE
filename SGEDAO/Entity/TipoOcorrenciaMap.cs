﻿using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Entity
{
   public class TipoOcorrenciaMap : EntityTypeConfiguration<TipoOcorrencia>
    {
        public TipoOcorrenciaMap()
        {
            this.HasKey(to => to.Id_Tipo_Ocorrencia);
            this.Property(to => to.Desc_Tipo_Ocorrencia).IsRequired().HasColumnName("DSC_TIPO_OCORRENCIA");
            this.Property(to => to.Tipo_Status).IsRequired().HasColumnName("FL_STATUS").HasColumnType("bit");

            this.ToTable("TIPO_OCORRENCIA");
        }
    }
}
