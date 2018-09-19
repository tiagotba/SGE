using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
  public  interface IDesocupacaoDAO
    {
        int Salvar(Desocupacao desc);
        IEnumerable<Desocupacao> ListarTodos();
        Desocupacao Pesquisar(int idDec);
    }
}
