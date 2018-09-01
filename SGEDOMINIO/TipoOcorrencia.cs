using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
   public  class TipoOcorrencia
    {
        public TipoOcorrencia()
        {
            Ocorrencias = new List<Ocorrencia>();
        }
        public int Id_Tipo_Ocorrencia { get; set; }

        public string Desc_Tipo_Ocorrencia { get; set; }

        public bool Tipo_Status { get; set; }

        public virtual IList<Ocorrencia> Ocorrencias { get; set; }
    }
}
