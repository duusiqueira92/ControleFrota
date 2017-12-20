using DAL.Interfaces;

namespace DAL
{
    public class ObjetoServices : IObjetoServices
    {
        private readonly IObjetoRepository _objetoRepository;

        public ObjetoServices(IObjetoRepository objetoRepository)
        {
            _objetoRepository = objetoRepository;
        }

        public string CadastrarObjeto(Objeto objeto)
        {
            _objetoRepository.CadastrarObjeto(objeto);
            return "Objeto cadastrado com sucesso!";
        }
    }
}
