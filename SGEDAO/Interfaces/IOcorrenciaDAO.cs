using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
  public  interface IOcorrenciaDAO
    {
        bool Salvar(Ocorrencia oco);
        IEnumerable<Ocorrencia> ListarTodas();
        void Editar(Ocorrencia oco);
        Ocorrencia Pesquisar(int idOco);
    }
}
