using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
   public class Estadia
    {
        public int Id_Estadia { get; set; }

        public int Id_Ocupacao { get; set; }

        public int Id_Desocupacao { get; set; }

        public decimal Valor_Estadia { get; set; }

        public int Qtd_Ocorrencia { get; set; }
    }
}
