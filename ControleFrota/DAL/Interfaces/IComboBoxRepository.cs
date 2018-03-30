using System.Data;

namespace DAL.Interfaces
{
    public interface IComboBoxRepository
    {
        DataTable CarregarEstados();
        DataTable CarregarOrgaoEmissor();
        DataTable CarregarCombustivel();
        DataTable CarregarCategoria();
        DataTable CarregarPlantao();
        DataTable CarregarEquipe();
        DataTable CarregarViatura();
        DataTable CarregarViaturaDt();
        DataTable CarregarNatOcorrencia();
        DataTable CarregarMotorista(int plantao, int equipe);
        DataTable CarregarEncarregado(int plantao, int equipe);
     }
}
