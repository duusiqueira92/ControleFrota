using DAL;
using System.Collections.Generic;
using System.Data;

namespace BLL.Interfaces
{
    public interface IParteServices
    {
        string CadastrarPartes(List<Partes> partes);
        DataTable RetornarParteCpf(string cpf);
        DataTable RetornarID(int limite);
    }
}
