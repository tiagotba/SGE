using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
   public class Veiculo
    {
        public Veiculo()
        {
            Ocupacoes = new List<Ocupacao>();
            Desocupacoes = new List<Desocupacao>();
        }
        public int Id_Veiculo { get; set; }

        public string Placa_Veic { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual IList<Ocupacao> Ocupacoes { get; set; }

        public virtual IList<Desocupacao> Desocupacoes { get; set; }

        public virtual IList<Ocorrencia> Ocorrencias { get; set; }
    }
}
