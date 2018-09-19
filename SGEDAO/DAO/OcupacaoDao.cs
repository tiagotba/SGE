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
    public class OcupacaoDao : IOcupacaoDAO
    {
        private readonly Bd_Sge_Fluent _sgeContext;

        public OcupacaoDao(Bd_Sge_Fluent sgeContext)
        {
            _sgeContext = sgeContext;
        }

        public IEnumerable<Ocupacao> ListarTodos()
        {
            return _sgeContext.ocupacao.Select(o => o);
        }

        public Ocupacao Pesquisar(int idOcu)
        {
            return _sgeContext.ocupacao.FirstOrDefault(o=>o.Id_Ocup == idOcu);
        }

        public int Salvar(Ocupacao ocu)
        {
            _sgeContext.Entry(ocu).State = System.Data.Entity.EntityState.Added;
            return _sgeContext.SaveChanges();
        }
    }
}
