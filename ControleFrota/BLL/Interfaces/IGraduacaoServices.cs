using DAL;
using System.Data;

namespace BLL.Interfaces
{
    public interface IGraduacaoServices
    {
        string CadastrarGraduacao(Graduacao graduacao);
        DataTable CarregarGraduacao(Graduacao graduacao);
    }
}
