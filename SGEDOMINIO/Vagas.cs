using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
   public class Vagas
    {
        public Vagas()
        {
            Ocupacoes = new List<Ocupacao>();
        }
        public int Id_Vaga { get; set; }

        public string Numero_Vaga { get; set; }

        public virtual Setor setor { get; set; }

        public virtual IList<Ocupacao> Ocupacoes { get; set; }

        public virtual IList<Desocupacao> Desocupacoes { get; set; }
    }
}
