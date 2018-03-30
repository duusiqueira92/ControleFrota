using System.Data;

namespace DAL.Interfaces
{
    public interface IGerenciadorPlantaoRepository
    {
        void AlterarPlantao(int id, int plantao, int equipe, int posicao);
        DataTable CarregarPlantao();
        DataTable CarregarAgentes();
        DataTable CarregarEquipe();
        DataTable CarregarPosicao();
    }
}
