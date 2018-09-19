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
    public class DesocupacaoDao : IDesocupacaoDAO
    {
        private readonly Bd_Sge_Fluent _sgeContext;

        public DesocupacaoDao(Bd_Sge_Fluent sgeContext)
        {
            _sgeContext = sgeContext;
        }

        public IEnumerable<Desocupacao> ListarTodos()
        {
            return _sgeContext.desocupacao.Select(d => d);
        }

        public Desocupacao Pesquisar(int idDec)
        {
            return _sgeContext.desocupacao.FirstOrDefault(d => d.Id_Desocupacao == idDec);
        }

        public int Salvar(Desocupacao desc)
        {
            _sgeContext.Entry(desc).State = System.Data.Entity.EntityState.Added;
            return _sgeContext.SaveChanges();
        }
    }
}
