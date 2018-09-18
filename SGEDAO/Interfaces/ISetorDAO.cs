using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
  public  interface ISetorDAO
    {
        int Salvar(Setor set);
        IEnumerable<Setor> ListarTodos();
        Setor Pesquisar(int idSet);
    }
}
