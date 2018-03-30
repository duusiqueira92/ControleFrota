using DAL;
using System.Data;

namespace BLL.Interfaces
{
    public interface IFuncionarioServices
    {
        string AdicionarFuncionario(Funcionario funcionario);
        string AlterarFuncionario(Funcionario funcionario);
        string ExcluirFuncionario(Funcionario funcionario);
        string AlterarPlantao(int plantao, int equipe, int id);
        DataTable CarregarEquipe();
        DataTable CarregarPlantao();
    }
}
