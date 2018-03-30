using BLL.Interfaces;
using DAL;
using DAL.Interfaces;

namespace BLL
{
    public class VeiculoAbordadoServices : IVeiculoAbordadoServices
    {
        private IVeiculoAbordadoRepository _veiculoAbordadoRepository;
        public VeiculoAbordadoServices(IVeiculoAbordadoRepository veiculoAbordadoRepository)
        {
            _veiculoAbordadoRepository = veiculoAbordadoRepository;
        }
        public string CadastrarVeiculoAbordado(VeiculoAbordado veiculoAbordado)
        {
            _veiculoAbordadoRepository = new VeiculoAbordadoRepository();
            _veiculoAbordadoRepository.CadastrarVeiculoAbordado(veiculoAbordado);
            return "Veículo abordado cadastrado com sucesso!";
        }
    }
}
