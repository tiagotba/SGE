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
    public class VagasDao : IVagasDAO
    {
        private readonly Bd_Sge_Fluent _sgeContext;

        public VagasDao(Bd_Sge_Fluent sgeContext)
        {
            _sgeContext = sgeContext;
        }
        public void Editar(Vagas vag)
        {
            var entity = Pesquisar(vag.Id_Vaga);
            if (entity != null)
            {
                _sgeContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                _sgeContext.SaveChanges();
            }
        }

        public bool Excluir(int idVag)
        {
            bool result = false;
            var entity = Pesquisar(idVag);
            
            if(entity != null)
            {
                _sgeContext.vagas.Remove(entity);
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public IEnumerable<Vagas> ListarTodos()
        {
            return _sgeContext.vagas.Select(v => v);
        }

        public Vagas Pesquisar(int idVag)
        {
            return _sgeContext.vagas.FirstOrDefault(v => v.Id_Vaga == idVag);
        }

        public int Salvar(Vagas vag)
        {
            _sgeContext.Entry(vag).State = System.Data.Entity.EntityState.Added;
            return  _sgeContext.SaveChanges();

        }
    }
}
