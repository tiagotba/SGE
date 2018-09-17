using SGEDAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGEDOMINIO;
using SGEDAO.Entity;

namespace SGEDAO.DAO
{
    public class UsuarioDao : IUsuarioDAO
    {
        private readonly Bd_Sge_Fluent _sgeContext;

        public UsuarioDao(Bd_Sge_Fluent sgeContext)
        {
            _sgeContext = sgeContext;
        }

        public void Editar(Usuario usu)
        {
            var usuario = Pesquisar(usu.Id_Usuario);
            if (usuario!= null)
            {
                _sgeContext.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                _sgeContext.SaveChanges();
            }
        }

        public bool Excluir(int idUsu)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Usuario Pesquisar(int idUsu)
        {
            return _sgeContext.usuario.FirstOrDefault(u => u.Id_Usuario == idUsu);
        }

        public bool Salvar(Usuario usu)
        {
            throw new NotImplementedException();
        }
    }
}
