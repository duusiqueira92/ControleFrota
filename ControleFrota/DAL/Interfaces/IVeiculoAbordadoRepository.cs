using System.Data;
namespace DAL.Interfaces
{
    public interface IVeiculoAbordadoRepository
    {
        void CadastrarVeiculoAbordado(VeiculoAbordado veiculoAbordado);
        DataTable CarregarVeiculoAbordado(int equipe);
    }
}
