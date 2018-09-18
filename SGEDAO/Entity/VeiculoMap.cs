﻿using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Entity
{
  public  class VeiculoMap : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoMap()
        {
            this.HasKey(v => v.Id_Veiculo);
            this.Property(v => v.Placa_Veic).IsRequired().HasColumnName("PLC_VEICULO").HasMaxLength(8);
           

            this.ToTable("VEIC_VEICULO");

        }
    }
}
