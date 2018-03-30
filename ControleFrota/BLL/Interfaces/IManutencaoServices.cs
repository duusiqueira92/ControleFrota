using DAL;
using System.Data;

namespace BLL.Interfaces
{
    public interface IManutencaoServices
    {
        string CadastrarManutencao(Manutencao manutencao);
        DataTable CarregarManutencao(int id);
    }
}
