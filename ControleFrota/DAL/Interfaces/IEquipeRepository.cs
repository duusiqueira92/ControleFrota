﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IEquipeRepository
    {
        void CadastrarEquipe(Equipe equipe);
        void CadastrarAbordado(Abordado abordado);
    }
}
