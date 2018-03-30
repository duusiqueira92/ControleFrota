using DAL;
using DAL.Interfaces;
using BLL.Interfaces;

namespace BLL
{
    public class ObjetoServices : IObjetoServices
    {
        IObjetoRepository _objetoRepository;

        public ObjetoServices(IObjetoRepository objetoRepository)
        {
            _objetoRepository = objetoRepository;
        }

        public string CadastrarObjeto(Objeto objeto)
        {
            _objetoRepository = new ObjetoRepository();
            _objetoRepository.CadastrarObjeto(objeto);
            return "Objeto cadastrado com sucesso!";
        }
    }
}
