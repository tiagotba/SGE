using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
   public  class TipoOcorrencia
    {
        public int Id_Tipo_Ocorrencia { get; set; }

        public string Desc_Tipo_Ocorrencia { get; set; }

        public bool Tipo_Status { get; set; }

        public IList<Ocorrencia> Ocorrencias { get; set; }
    }
}
