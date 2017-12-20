using DAL.Interfaces;

namespace DAL
{
    public class ApreensaoServices : IApreensoesServices
    {
        private readonly IApreensoesRepository _apreensoesRepository;
        public ApreensaoServices(IApreensoesRepository apreesoesRepository)
        {
            _apreensoesRepository = apreesoesRepository;
        }
        public string CadastrarApreensao(Apreensao apreensao)
        {
            _apreensoesRepository.CadastrarApreensao(apreensao);
            return "Apreensão cadastrada com sucesso!";
        }
    }
}
