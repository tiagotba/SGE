using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
  public  class Ocupacao
    {
        public int Id_Ocupacao { get; set; }

        public DateTime Data_Hora_Entrada { get; set; }

        public int Setor { get; set; }

        public int Vaga { get; set; }

        public int Veiculo { get; set; }
    }
}
