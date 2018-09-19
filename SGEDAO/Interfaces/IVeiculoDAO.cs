using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
  public  interface IVeiculoDAO
    {
        int Salvar(Veiculo veic);
        IEnumerable<Veiculo> ListarTodos();
        void Editar(Veiculo veic);
        Veiculo Pesquisar(int idVeic);
    }
}
