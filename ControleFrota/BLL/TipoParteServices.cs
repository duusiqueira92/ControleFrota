﻿using DAL;
using DAL.Interfaces;
using BLL.Interfaces;

namespace BLL
{
    public class TipoParteServices : ITipoParteServices
    {
        private readonly ITipoParteRepository _tipoParteRepository;
        public TipoParteServices(ITipoParteRepository tipoParteRepository)
        {
            _tipoParteRepository = tipoParteRepository;
        }

        public string CadastrarParte(TipoParte tipoPartes)
        {
            _tipoParteRepository.CadastrarParte(tipoPartes);
            return "Tipo de parte cadastrado!";
        }
    }
}
