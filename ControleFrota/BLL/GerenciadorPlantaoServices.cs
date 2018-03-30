using DAL.Interfaces;
using System.Data;
using DAL;
using BLL.Interfaces;

namespace BLL
{
    public class GerenciadorPlantaoServices : IGerenciadorPlantaoServices
    {
        IGerenciadorPlantaoRepository _gerenciadorRepository;
        public string AlterarPlantao(int id, int plantao, int equipe, int posicao)
        {
            _gerenciadorRepository = new GerenciadorPlantaoRepository();
            _gerenciadorRepository.AlterarPlantao(id, plantao, equipe, posicao);
            return "Alteração do plantão realizada com sucesso!";
        }

        public DataTable CarregarAgentes()
        {
            _gerenciadorRepository = new GerenciadorPlantaoRepository();
            return _gerenciadorRepository.CarregarAgentes();
        }

        public DataTable CarregarEquipes()
        {
            _gerenciadorRepository = new GerenciadorPlantaoRepository();
            return _gerenciadorRepository.CarregarEquipe();
        }

        public DataTable CarregarPlantao()
        {
            _gerenciadorRepository = new GerenciadorPlantaoRepository();
            return _gerenciadorRepository.CarregarPlantao();
        }

        public DataTable CarregarPosicao()
        {
            _gerenciadorRepository = new GerenciadorPlantaoRepository();
            return _gerenciadorRepository.CarregarPosicao();
        }
    }
}
