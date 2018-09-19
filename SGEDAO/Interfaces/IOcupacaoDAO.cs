using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
   public interface IOcupacaoDAO
    {
        int Salvar(Ocupacao ocu);
        IEnumerable<Ocupacao> ListarTodos();
        Ocupacao Pesquisar(int idOcu);
    }
}
