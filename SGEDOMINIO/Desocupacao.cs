using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
   public class Desocupacao
    {
        public int Id_Desocupacao { get; set; }

        public DateTime Data_Hora_Saida { get; set; }

        public int Vaga { get; set; }

        public int Veiculo { get; set; }
    }
}
