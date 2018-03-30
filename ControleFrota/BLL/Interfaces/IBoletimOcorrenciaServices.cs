using DAL;
using System.Collections.Generic;
using System.Data;

namespace BLL.Interfaces
{
    public interface IBoletimOcorrenciaServices
    {
        string CadastrarBoletimOcorrencia(BoletimOcorrencia boletimOcorrencia);
        DataTable RetornarIDBoletim();
        DataTable RetornarID(int limite);
        string CadastrarParte(List<Partes>partes);
        DataTable RetornarParteCpf(string cpf);
        DataTable CarregarEstado();
        DataTable CarregarOrgEmissor();
        DataTable CarregarCategoria();
        DataTable CarregarNatOcorrencia();
        DataTable CarregarViatura();
        DataTable CarregarEquipe();
        DataTable CarregarPlantao();
        DataTable CarregarMotorista(int plantao, int equipe);
        DataTable CarregarEncarregado(int plantao, int equipe);
        DataTable CarregarAuxiliar(int plantao, int equipe);
    }
}
