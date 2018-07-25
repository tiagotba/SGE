﻿using SGEDOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEREPOSITORIO.Interfaces
{
  public  interface IDesocupacaoRespository
    {
        bool Salvar(Desocupacao desc);
        bool Excluir(int idDesc);
    }
}