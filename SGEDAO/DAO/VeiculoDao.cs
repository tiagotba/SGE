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
    public class VeiculoDao : IVeiculoDAO
    {
        private readonly Bd_Sge_Fluent _sgeContext;

        public VeiculoDao(Bd_Sge_Fluent sgeContext)
        {
            _sgeContext = sgeContext;
        }

        public void Editar(Veiculo veic)
        {
            var entity = Pesquisar(veic.Id_Veiculo);
            if (entity != null)
            {
                _sgeContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                _sgeContext.SaveChanges();
            }
        }

        public IEnumerable<Veiculo> ListarTodos()
        {
            return _sgeContext.veiculos.Select(v => v);
        }

        public Veiculo Pesquisar(int idVeic)
        {
            return _sgeContext.veiculos.FirstOrDefault(v => v.Id_Veiculo == idVeic);
        }

        public int Salvar(Veiculo veic)
        {
            _sgeContext.Entry(veic).State = System.Data.Entity.EntityState.Added;
            return _sgeContext.SaveChanges();
        }
    }
}
