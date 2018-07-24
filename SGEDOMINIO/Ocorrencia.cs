using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
  public  class Ocorrencia
    {
        public int Id_Ocorrencia { get; set; }

        public DateTime Data_Hora_Ocorrencia { get; set; }

        public string Titulo_Ocorrencia{ get; set; }

        public string Desc_Ocorrencia { get; set; }

        public int Veiculo { get; set; }

        public int Usuario { get; set; }

        public int TipoOcorrencia { get; set; }
    }
}
