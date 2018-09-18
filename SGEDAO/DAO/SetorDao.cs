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
    public class SetorDao : ISetorDAO
    {
        private readonly Bd_Sge_Fluent _sgeContext;

        public IEnumerable<Setor> ListarTodos()
        {
            return _sgeContext.setor.Select(s => s);
        }

        public Setor Pesquisar(int idSet)
        {
            return _sgeContext.setor.FirstOrDefault(s =>s.Id_Setor == idSet);
        }

        public int Salvar(Setor set)
        {
            _sgeContext.Entry(set).State = System.Data.Entity.EntityState.Added;
            return _sgeContext.SaveChanges();
        }
    }
}
