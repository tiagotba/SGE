using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
   public interface ITipoOcorrenciaDAO
    {
        int Salvar(TipoOcorrencia tip);
        IEnumerable<TipoOcorrencia> ListarTodos();
        void Editar(TipoOcorrencia tip);
        bool Excluir(int idTip);
        TipoOcorrencia Pesquisar(int idTip);
    }
}
