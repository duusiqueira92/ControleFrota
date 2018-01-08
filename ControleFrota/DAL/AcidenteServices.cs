using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AcidenteServices : IAcidenteServices
    {
        private readonly IAcidenteRepository _acidenteRepository;
        public AcidenteServices(IAcidenteRepository acidenteRepository)
        {
            _acidenteRepository = acidenteRepository;
        }

        public string CadastrarAcidente(Acidente acidente)
        {
            _acidenteRepository.CadastrarAcidente(acidente);
            return "Acidente cadastrado com sucesso";
        }
    }
}
