using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEREPOSITORIO.Interfaces
{
  public  interface IUsuarioRepository
    {
        bool Salvar(Usuario usu);
        IEnumerable<Usuario> ListarTodos();
        void Editar(Usuario usu);
        bool Excluir(int idUsu);
        Usuario Pesquisar(int idUsu);
    }
}
