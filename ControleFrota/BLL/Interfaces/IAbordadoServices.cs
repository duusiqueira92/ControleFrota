using DAL;
using System.Data;

namespace BLL.Interfaces
{
    public interface IAbordadoServices
    {
        string CadastrarAbordado(Abordado abordado);
        DataTable CarregarAbordados(int equipe);
    }
}
