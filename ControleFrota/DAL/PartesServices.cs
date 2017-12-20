using DAL.Interfaces;

namespace DAL
{
    public class PartesServices : IPartesServices
    {
        private readonly IParteRepository _partesRepository;

        public PartesServices(IParteRepository partesRepository)
        {
            _partesRepository = partesRepository;
        }
        public string CadastrarPartes(Partes partes)
        {
            _partesRepository.CadastrarParte(partes);
            return "Parte cadastrada com sucesso!";
        }
    }
}
