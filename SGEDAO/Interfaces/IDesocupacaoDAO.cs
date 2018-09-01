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
        bool Salvar(Desocupacao desc);
        bool Excluir(int idDesc);
    }
}
