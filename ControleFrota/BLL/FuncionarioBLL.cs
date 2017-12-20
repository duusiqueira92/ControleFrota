using DAL;
using DAL.Interfaces;

namespace BLL
{
    public class FuncionarioBLL : IFuncionarioRepository
    {
        private readonly IFuncionarioRepository _funcionarioReposiroty;
        FuncionarioServices novoFuncionario;

        public FuncionarioBLL(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioReposiroty = funcionarioRepository;
        }
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if (funcionario.Id == 0)//alguma condicao
            {
                novoFuncionario = new FuncionarioServices(_funcionarioReposiroty);
                novoFuncionario.AdicionarFuncionario(funcionario);
            }
        }
    }
}
