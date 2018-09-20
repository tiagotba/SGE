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
  public  class SetorRepositorio
    {
        private SetorDao dao;
        private readonly Bd_Sge_Fluent _sgeContext = new Bd_Sge_Fluent();

        public SetorRepositorio()
        {
            dao = new SetorDao(_sgeContext);
        }

        public bool Editar(Setor setor)
        {
            if (setor == null || setor.Id_Setor == 0)
            {
                return false;
            }
            else
            {
                Salvar(setor);
                return true;
            }
        }

        public int Salvar(Setor setor)
        {
            int idSetor = 0;

            if (setor != null && setor.Id_Setor == 0)
            {
                idSetor = dao.Salvar(setor);
            }
            //else
            //{
            //    dao.Editar(setor);
            //}

            return idSetor;
        }


        public IEnumerable<Setor> List()
        {
            var setores = dao.ListarTodos();
            return setores;
        }

        public Setor Pesquisar(int idSetor)
        {
            Setor lSetor = new Setor();
            lSetor = dao.Pesquisar(idSetor);
            return lSetor;
        }
    }
}
