using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Entity
{
   public class VagasMap : EntityTypeConfiguration<Vagas>
    {
        public VagasMap()
        {
            this.HasKey(v => v.Id_Vaga);
            this.Property(v => v.Numero_Vaga).HasMaxLength(3);
        
            this.HasRequired(v => v.setor)
                   .WithMany(x => x.Vagas)
                   .Map(m => m.MapKey("Id_Setor"));
         
            this.ToTable("VAG_VAGA");
        }
    }
}
