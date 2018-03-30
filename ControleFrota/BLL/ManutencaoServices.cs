using DAL;
using DAL.Interfaces;
using System.Data;
using BLL.Interfaces;

namespace BLL
{
    public class ManutencaoServices : IManutencaoServices
    {
        IManutencaoRespository _manutencaoRepository;

        public string CadastrarManutencao(Manutencao manutencao)
        {
            _manutencaoRepository = new ManutencaoRepository();
            _manutencaoRepository.CadastrarManutencao(manutencao);
            return "Manutenção cadastrada com sucesso!";
        }

        public DataTable CarregarManutencao(int id)
        {
            _manutencaoRepository = new ManutencaoRepository();
            return _manutencaoRepository.CarregarManutencao(id);
        }
    }
}
