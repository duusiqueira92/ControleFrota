using DAL.Interfaces;
using DAL;
using System.Data;
using BLL.Interfaces;

namespace BLL
{
    public class AcidenteServices : IAcidenteServices
    {
        IComboBoxRepository _comboBoxRepository;
        IAcidenteRepository _acidenteRepository;
        public AcidenteServices(IAcidenteRepository acidenteRepository)
        {
            _acidenteRepository = acidenteRepository;
        }

        public string CadastrarAcidente(Acidente acidente)
        {
            _acidenteRepository = new AcidenteRepository();
            _acidenteRepository.CadastrarAcidente(acidente);
            return "Acidente cadastrado com sucesso";
        }

        public DataTable RetornarEstadoUF()
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarEstados();
        }
    }
}
