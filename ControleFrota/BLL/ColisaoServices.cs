using BLL.Interfaces;
using DAL;
using DAL.Interfaces;

namespace BLL
{
    public class ColisaoServices : IColisaoServices
    {
        private readonly IColisaoRepository _colisaoRepository;
        public ColisaoServices(IColisaoRepository colisaoRepository)
        {
            _colisaoRepository = colisaoRepository;
        }
        public string CadastrarColisao(Colisao colisao)
        {
            _colisaoRepository.CadastrarColisao(colisao);
            return "Colisão cadastrada com sucesso!";
        }
    }
}
