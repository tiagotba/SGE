using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDOMINIO
{
   public class Usuario
    {
        public int Id_Usuario { get; set; }

        public string Matr_Func { get; set; }

        public string Tel_Func { get; set; }

        public string Login_Func { get; set; }

        public string Senha_Func { get; set; }

        public IList<Ocorrencia> Ocorrencias { get; set; }
    }
}
