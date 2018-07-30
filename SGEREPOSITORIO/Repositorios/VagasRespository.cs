using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGEDAO;
using SGEDAO.DAO;
using SGEDOMINIO;
using SGEDAO.Entity;

namespace SGEREPOSITORIO.Repositorios
{
    public class VagasRespository
    {
        private VagasDao dao;
        private Bd_Sge_Fluent _sgeContext = new Bd_Sge_Fluent();
        public VagasRespository()
        {
            dao = new VagasDao(_sgeContext);
        }

        public IEnumerable<Vagas> ListarTodos()
        {
            return dao.ListarTodos();
        }

        public void Editar(Vagas vag)
        {
            if (vag == null || vag.Id_Vaga == 0)
            {
                throw new Exception("O identificador da vaga não foi informado");
            }
            else
            {
                dao.Editar(vag);
            }
        }

        public void Salvar(Vagas vag)
        {
            dao.Salvar(vag);
        }

        public bool Excluir(int idVag)
        {
            if (dao.Excluir(idVag))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
