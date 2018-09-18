using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Entity
{
   public class SetorMap : EntityTypeConfiguration<Setor>
    {
        public SetorMap()
        {
            this.HasKey(s => s.Id_Setor);

            this.Property(s => s.Nome_Setor).HasMaxLength(100);

            this.ToTable("SET_SETOR");

        }
    }
}
