using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
   public interface ITipoOcorrencia
    {
        bool Salvar(TipoOcorrencia tip);
        IEnumerable<TipoOcorrencia> ListarTodos();
        TipoOcorrencia Pesquisar(int idTip);
    }
}
