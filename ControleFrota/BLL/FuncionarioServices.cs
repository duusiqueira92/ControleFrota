using System;
using DAL;
using DAL.Interfaces;
using System.Data;
using BLL.Interfaces;

namespace BLL
{
    public class FuncionarioServices :  IFuncionarioServices
    {
        IFuncionarioRepository _funcionarioRepository;
        IComboBoxRepository _comboBoxRepository;

        public string AdicionarFuncionario(Funcionario funcionario)
        {
            if (!funcionario.Validacao())
                return "CPF inválido!";

            _funcionarioRepository = new FuncionarioRepository();
            _funcionarioRepository.AdicionarFuncionario(funcionario);
            return funcionario.Qra + " Cadastrado com sucesso!";
        }

        public string AlterarFuncionario(Funcionario funcionario)
        {
            if (!funcionario.Validacao())
                return "CPF inválido";

            _funcionarioRepository = new FuncionarioRepository();
            _funcionarioRepository.AlterarFuncionario(funcionario);
            return funcionario.Qra + " Alterado com sucesso!";
        }

        public string AlterarPlantao(int plantao, int equipe, int id)
        {
            _funcionarioRepository = new FuncionarioRepository();
            _funcionarioRepository.AlterarPlantao(plantao, equipe, id);
            return "Plantão atualizado com sucesso!";
        }

        public string ExcluirFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public DataTable CarregarFuncionario()
        {
            _funcionarioRepository = new FuncionarioRepository();
            return _funcionarioRepository.CarregarFuncionario();
        }

        public DataTable CarregarEstado()
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarEstados();
        }

        public DataTable CarregarCategoria()
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarCategoria();
        }

        public DataTable CarregarOrgEmissor()
        {
            _comboBoxRepository = new ComboBoxRepository();
            return _comboBoxRepository.CarregarOrgaoEmissor();
        }

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

        public DataTable CarregarEquipamentos(int agente)
        {
            _funcionarioRepository = new FuncionarioRepository();
            return _funcionarioRepository.CarregarEquipamentos(agente);
        }
    }
}
