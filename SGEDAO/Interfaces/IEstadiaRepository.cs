using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
  public  interface IEstadiaRepository
    {
        bool Salvar(Estadia est);
        bool Excluir(int idEst);
        Estadia Pesquisar(int idEst);
    }
}
