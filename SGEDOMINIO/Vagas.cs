using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
   public class Vagas
    {
        public int Id_Vaga { get; set; }

        public string Numero_Vaga { get; set; }

        public int Setor { get; set; }

        public IList<Ocupacao> Ocupacoes { get; set; }

        public IList<Desocupacao> Desocupacoes { get; set; }
    }
}
