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

            //this.HasMany(s=>s.Ocupacoes)
            //    .WithOptional(o=>o.setor)
            //    .HasForeignKey(x=>x.Id_Setor);


            //this.HasRequired(s => s.Ocupacoes)
            //    .WithMany()
            //   // .Map(m => m.MapKey("Id_Setor"))
            //    .HasForeignKey(x => x.Id_Setor);
                

            //this.HasRequired(s => s.Vagas)
            //   .WithMany()
            //   .Map(m => m.MapKey("Id_Setor"));


            this.ToTable("SET_SETOR", "bd_sge_sql");

        }
    }
}
