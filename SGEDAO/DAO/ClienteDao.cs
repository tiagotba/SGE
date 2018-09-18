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
    public class ClienteDao : IClienteDAO
    {
        private readonly Bd_Sge_Fluent _sgeContext;

        public ClienteDao(Bd_Sge_Fluent sgeContext)
        {
            _sgeContext = sgeContext;
        }

        public void Editar(Cliente cli)
        {
            var entity = Pesquisar(cli.Id_Cliente);
            if (entity != null)
            {
                _sgeContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                _sgeContext.SaveChanges();
            }
        }

        public IEnumerable<Cliente> ListarTodos()
        {
            return _sgeContext.cliente.Select(c => c);
        }

        public Cliente Pesquisar(int idCli)
        {
            return _sgeContext.cliente.FirstOrDefault(v => v.Id_Cliente == idCli);
        }

        public int Salvar(Cliente cli)
        {
            _sgeContext.Entry(cli).State = System.Data.Entity.EntityState.Added;
            return _sgeContext.SaveChanges();
        }
    }
}
