using DAL;
using DAL.Interfaces;
using System.Data;
using BLL.Interfaces;

namespace BLL
{
    public class VeiculoServices : IVeiculoServices
    {
        IComboBoxRepository _comboBoxRepository;
        IVeiculoRepository _veiculoRespository;

        public string CadastrarVeiculo(Veiculo veiculo)
        {
            if (!veiculo.ValidarPlaca())
                return "Emplacamento inválido";

            _veiculoRespository = new VeiculoRepositoy();
            _veiculoRespository.CadastrarVeiculo(veiculo);
            return "Veiculo cadastrado com sucesso!";
        }

        public DataTable CarregarVeiculos()
        {
            _veiculoRespository = new VeiculoRepositoy();
            return _veiculoRespository.CarregarVeiculos();
        }

        public DataTable CarregarEstado()
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarEstados();
        }

        public DataTable CarregarCombustivel()
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarCombustivel();
        }
    }
}
