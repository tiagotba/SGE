using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
   public class Cliente
    {
        public int Id_Cliente { get; set; }

        public string Nome_Cliente { get; set; }

        public string Rg_Cliente { get; set; }

        public string Cpf_Cliente { get; set; }

        public bool E_Func_Cliente { get; set; }

        public string Matr_Func_Cliente { get; set; }
    }
}
