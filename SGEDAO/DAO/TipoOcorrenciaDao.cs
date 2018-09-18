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
    public class TipoOcorrenciaDao : ITipoOcorrenciaDAO
    {
        private readonly Bd_Sge_Fluent _sgeContext;

        public TipoOcorrenciaDao(Bd_Sge_Fluent sgeContext)
        {
            _sgeContext = sgeContext;
        }

        public void Editar(TipoOcorrencia tip)
        {
            var entity = Pesquisar(tip.Id_Tipo_Ocorrencia);
            if (entity != null)
            {
                _sgeContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                _sgeContext.SaveChanges();
            }
        }

        public bool Excluir(int idTip)
        {
            bool result = false;
            var entity = Pesquisar(idTip);

            if (entity != null)
            {
                _sgeContext.tipo_ocorrencia.Remove(entity);
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public IEnumerable<TipoOcorrencia> ListarTodos()
        {
            return _sgeContext.tipo_ocorrencia.Select(to => to);
        }

        public TipoOcorrencia Pesquisar(int idTip)
        {
            return _sgeContext.tipo_ocorrencia.FirstOrDefault(to=>to.Id_Tipo_Ocorrencia == idTip);
        }

        public int Salvar(TipoOcorrencia tip)
        {
            _sgeContext.Entry(tip).State = System.Data.Entity.EntityState.Added;
            return _sgeContext.SaveChanges();
        }
    }
}
