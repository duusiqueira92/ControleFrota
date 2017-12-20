using DAL.Interfaces;

namespace DAL
{
    public class VeiculoServices : IVeiculoServices
    {
        private readonly IVeiculoRepository _veiculoRepository;
        public VeiculoServices(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }
        public string CadastrarVeiculo(Veiculo veiculo)
        {
            if (veiculo.ValidarPlaca())
               return "Emplacamento inválido";

            _veiculoRepository.CadastrarVeiculo(veiculo);
            return "Veículo cadastrado com sucesso!";
        }
    }
}
