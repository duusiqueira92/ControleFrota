using System.Collections.Generic;
using System.Data;

namespace DAL.Interfaces
{
    public interface IParteRepository
    {
        void CadastrarParte(List<Partes> partes);
        DataTable RetornarParteCpf(string cpf);
        DataTable RetornarID(int limite);
    }
}
