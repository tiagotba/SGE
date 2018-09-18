using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
   public interface IClienteDAO
    {
        int Salvar(Cliente cli);
        IEnumerable<Cliente> ListarTodos();
        void Editar(Cliente cli);
        Cliente Pesquisar(int idCli);

    }
}
