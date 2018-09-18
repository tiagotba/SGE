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
    public class OcorrenciaDao : IOcorrenciaDAO
    {
        private readonly Bd_Sge_Fluent _sgeContext;

        public OcorrenciaDao(Bd_Sge_Fluent sgeContext)
        {
            _sgeContext = sgeContext;
        }

        public void Editar(Ocorrencia oco)
        {
            var entity = Pesquisar(oco.Id_Ocorrencia);
            if (entity != null)
            {
                _sgeContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                _sgeContext.SaveChanges();
            }
        }

        public IEnumerable<Ocorrencia> ListarTodas()
        {
            return _sgeContext.ocorrencia.Select(oc => oc);
        }

        public Ocorrencia Pesquisar(int idOco)
        {
            return _sgeContext.ocorrencia.FirstOrDefault(oc => oc.Id_Ocorrencia == idOco);
        }

        public int Salvar(Ocorrencia oco)
        {
            _sgeContext.Entry(oco).State = System.Data.Entity.EntityState.Added;
            return _sgeContext.SaveChanges();
        }
    }
}
