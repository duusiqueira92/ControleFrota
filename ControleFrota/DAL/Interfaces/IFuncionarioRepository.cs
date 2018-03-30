using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IFuncionarioRepository
    {
        void AdicionarFuncionario(Funcionario funcionario);
        DataTable CarregarFuncionario();
        void AlterarFuncionario(Funcionario funcionario);
        void AlterarPlantao(int plantao, int equipe, int id);
        DataTable CarregarEquipamentos(int agente);
    }
}
