using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
  public  interface IVeiculoRepository
    {
        bool Salvar(Veiculo veic);
        IEnumerable<Veiculo> ListarTodos();
        Veiculo Pesquisar(int idVeic);
    }
}
