using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
  public  class Ocupacao
    {
        public Ocupacao()
        {
            Estadia = new Estadia();
        }
        public int Id_Ocup { get; set; }

        public DateTime Data_Hora_Entrada { get; set; }


        public virtual Setor setor { get; set; }


        public virtual Vagas vaga { get; set; }


        public virtual Veiculo veiculo { get; set; }


        public virtual Estadia Estadia { get; set; }
    }
}
