using DAL;
using System.Data;

namespace BLL.Interfaces
{
    public interface IVeiculoServices
    {
        string CadastrarVeiculo(Veiculo veiculo);
        DataTable CarregarEstado();
        DataTable CarregarVeiculos();
        DataTable CarregarCombustivel();
    }
}
