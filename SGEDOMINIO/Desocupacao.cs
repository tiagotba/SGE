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

     //   public int Id_Vaga { get; set; }

        public virtual Vagas Vaga { get; set; }

    //    public int Id_Veiculo { get; set; }

        public virtual Veiculo Veiculo { get; set; }

        public virtual Estadia Estadia { get; set; }
    }
}
