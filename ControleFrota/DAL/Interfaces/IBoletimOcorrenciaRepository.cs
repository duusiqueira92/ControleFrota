﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IBoletimOcorrenciaRepository
    {
        void CadastrarBoletimOcorrencia(BoletimOcorrencia boletimOcorrencia);
        DataTable RetornarIDBoletim();
    }
}
