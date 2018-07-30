using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDAO.Interfaces
{
   public interface IOcupacaoRepository
    {
        bool Salvar(Ocupacao ocu);
        bool Excluir(int idOcu);
    }
}
