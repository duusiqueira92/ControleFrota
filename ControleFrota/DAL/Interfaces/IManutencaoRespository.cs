using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IManutencaoRespository
    {
        void CadastrarManutencao(Manutencao manutencao);
        DataTable CarregarManutencao(int id_viatura);
    }
}
