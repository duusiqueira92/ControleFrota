using System.Data;

namespace BLL.Interfaces
{
    public interface IGerenciadorPlantaoServices
    {
        string AlterarPlantao(int id, int plantao, int equipe, int posicao);
        DataTable CarregarPlantao();
        DataTable CarregarAgentes();
        DataTable CarregarEquipes();
        DataTable CarregarPosicao();
    }
}
