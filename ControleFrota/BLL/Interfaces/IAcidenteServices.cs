using DAL;
using System.Data;

namespace BLL.Interfaces
{
    public interface IAcidenteServices
    {
        string CadastrarAcidente(Acidente acidente);
        DataTable RetornarEstadoUF();
    }
}
