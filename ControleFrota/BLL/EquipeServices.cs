using DAL.Interfaces;
using DAL;
using System.Data;
using BLL.Interfaces;

namespace BLL
{
    public class EquipeServices
    {
        IVeiculoAbordadoRepository _veiculoAbordadoRepository;
        IVeiculoAbordadoServices _veiculoAbordadoServices;
        IAbordadoServices _abordadoServices;
        IAbordadoRepository _abordadoRepository;
        IEquipeRepository _equipeRepository;
        IComboBoxRepository _comboBoxRepository;

        public DataTable CarregarPlantao()
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarPlantao();
        }

        public DataTable CarregarEquipe()
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarEquipe();
        }

        public DataTable CarregarMotorista(int plantao, int equipe)
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarMotorista(plantao, equipe);
        }

        public DataTable CarregarEncarregado(int plantao, int equipe)
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarEncarregado(plantao, equipe);
        }

        public DataTable CarregarViatura()
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarViatura();
        }

        public DataTable CarregarDataGrid()
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarViaturaDt();
        }

        public DataTable CarregarVeiculosAbordados(int equipe)
        {
            _veiculoAbordadoRepository = new VeiculoAbordadoRepository();
            return _veiculoAbordadoRepository.CarregarVeiculoAbordado(equipe);
        }

        public DataTable CarregarAbordados(int equipe)
        {
            _abordadoRepository = new AbordadoRepository();
            return _abordadoRepository.CarregarAbordados(equipe);
        }

        public string CadastrarEquipe(Equipe equipe)
        {
            _equipeRepository = new EquipeRepository();
            _equipeRepository.CadastrarEquipe(equipe);
            return "Equipe cadastrada com sucesso!";
        }

        public string CadastrarAbordado(Abordado abordado)
        {
            _abordadoServices = new AbordadoServices();
            return _abordadoServices.CadastrarAbordado(abordado);
        }

        public string CadastrarVeiculoAbordado(VeiculoAbordado veiculoAbordado)
        {
            _veiculoAbordadoServices = new VeiculoAbordadoServices(_veiculoAbordadoRepository);
            return _veiculoAbordadoServices.CadastrarVeiculoAbordado(veiculoAbordado);
        }

        public DataTable CarregarManutencao(int id_viatura)
        {
            ManutencaoRepository manutencao = new ManutencaoRepository();
            return manutencao.CarregarManutencao(id_viatura);
        }

    }
}
