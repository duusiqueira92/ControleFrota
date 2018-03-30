using System.Data;

namespace DAL.Interfaces
{
    public interface IAbordadoRepository
    {
        void CadastrarAbordado(Abordado abordado);
        DataTable CarregarAbordados(int equipe);
    }
}
