using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
   public class Setor
    {
        public int Id_Setor{ get; set; }
        public string Nome_Setor { get; set; }
        public IList<Vagas> Vagas { get; set; }
        public IList<Ocupacao> Ocupacoes { get; set; }
    }
}
