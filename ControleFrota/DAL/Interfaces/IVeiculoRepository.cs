using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IVeiculoRepository
    {
        void CadastrarVeiculo(Veiculo veiculo);
        DataTable CarregarVeiculos();
        DataTable CarregarManutencao(int veiculo);
    }
}
