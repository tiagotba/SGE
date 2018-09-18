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
            bool result = false;
            var entity = Pesquisar(idUsu);

            if (entity != null)
            {
                _sgeContext.usuario.Remove(entity);
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            return _sgeContext.usuario.Select(v => v);
        }

        public Usuario Pesquisar(int idUsu)
        {
            return _sgeContext.usuario.FirstOrDefault(u => u.Id_Usuario == idUsu);
        }

        public int Salvar(Usuario usu)
        {
            _sgeContext.Entry(usu).State = System.Data.Entity.EntityState.Added;
            return _sgeContext.SaveChanges();
        }
    }
}
