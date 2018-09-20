using SGEDAO.DAO;
using SGEDAO.Entity;
using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEBUSSINESS.SGEBUSSINESS
{
    public class VagasRepositorio
    {
        private VagasDao dao;
        private readonly Bd_Sge_Fluent _sgeContext = new Bd_Sge_Fluent();

        public VagasRepositorio()
        {
            dao = new VagasDao(_sgeContext);
        }

        public bool Editar(Vagas vagas)
        {
            if (vagas == null || vagas.Id_Vaga == 0)
            {
                return false;
            }
            else
            {
                Salvar(vagas);
                return true;
            }
        }

        public int Salvar(Vagas vaga)
        {
            int idVaga = 0;

            if (vaga != null && vaga.Id_Vaga == 0)
            {
                idVaga = dao.Salvar(vaga);
            }
            else
            {
                dao.Editar(vaga);
            }

            return idVaga;
        }

        public bool Excluir(int idPessoa)
        {
            if (dao.Excluir(idPessoa))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Vagas> List()
        {
            var vagas = dao.ListarTodos();
            return vagas;
        }

        public Vagas Pesquisar(int idVaga)
        {
            Vagas lVaga = new Vagas();
            lVaga = dao.Pesquisar(idVaga);
            return lVaga;
        }
    }
}
