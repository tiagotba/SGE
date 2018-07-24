using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
   public class Veiculo
    {
        public int Id_Veiculo { get; set; }

        public string Placa_Veic { get; set; }

        public IList<Ocupacao> Ocupacoes { get; set; }

        public IList<Desocupacao> Desocupacoes { get; set; }

        public IList<Ocorrencia> Ocorrencias { get; set; }
    }
}
