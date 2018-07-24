using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEREPOSITORIO.Interfaces
{
   public interface IVagasRespository
    {
        bool Salvar(Vagas vag);
        IEnumerable<Vagas> ListarTodos();
        void Editar(Vagas vag);
        bool Excluir(int idVag);
        Vagas Pesquisar(int idVag);
    }
}
