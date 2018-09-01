using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
  public  interface IEstadiaDAO
    {
        bool Salvar(Estadia est);
        bool Excluir(int idEst);
        Estadia Pesquisar(int idEst);
    }
}
