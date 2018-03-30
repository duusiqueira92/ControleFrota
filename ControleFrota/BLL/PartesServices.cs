using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class PartesServices : IParteServices
    {
        IParteRepository _partesRepository;

        public PartesServices(IParteRepository partesRepository)
        {
            _partesRepository = partesRepository;
        }

        public string CadastrarPartes(List<Partes> partes)
        {
            _partesRepository = new PartesRepository();
            _partesRepository.CadastrarParte(partes);
            return "Parte cadastrada com sucesso!";
        }

        public DataTable RetornarParteCpf(string cpf)
        {
            _partesRepository = new PartesRepository();
            return _partesRepository.RetornarParteCpf(cpf);
        }

        public DataTable RetornarID(int limite)
        {
            _partesRepository = new PartesRepository();
            return _partesRepository.RetornarID(limite);
        }
    }
}
