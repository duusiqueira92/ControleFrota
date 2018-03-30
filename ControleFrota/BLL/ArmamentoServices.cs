using DAL.Interfaces;
using System.Windows.Forms;
using System;
using DAL;
using BLL.Interfaces;

namespace BLL
{
    public class ArmamentoServices : IArmamentoServices
    {
        IArmamentoRepository _armamentoRepository;
            
        public string CadastrarArmamento(Armamento armamento)
        {
            _armamentoRepository = new ArmamentoRepository();
            _armamentoRepository.CadastrarArmamento(armamento);
            return "Armamento cadastrado com sucesso!";
        }
    }
}
