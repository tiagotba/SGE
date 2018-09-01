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
            this.HasRequired(i => i.setor).WithMany(i => i.Vagas)
                .HasForeignKey(i => i.setor);
            this.HasMany(v => v.Desocupacoes)
                .WithRequired(v => v.Vaga)
                .HasForeignKey(x => x.Id_Vaga);
            this.ToTable("VAG_VAGA", "bd_sge_sql");
        }
    }
}
