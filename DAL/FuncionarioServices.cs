using DAL.Interfaces;

namespace DAL
{
    public class FuncionarioServices : IFuncionarioServices
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioServices(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public string AdicionarFuncionario(Funcionario funcionario)
        {
            if (!funcionario.Validacao())
                return "Dados inválidos";

            _funcionarioRepository.AdicionarFuncionario(funcionario);
            return "Cadastrado com sucesso!";
        }
    }
}
