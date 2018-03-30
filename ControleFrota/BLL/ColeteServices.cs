using DAL.Interfaces;
using DAL;
using BLL.Interfaces;

namespace BLL
{
    public class ColeteServices : IColeteServices
    {
        IColeteRepository _coleteRepository;
        public string CadastrarColete(Colete colete)
        {
            _coleteRepository = new ColeteRepository();
            _coleteRepository.CadastrarColete(colete);
            return "Colete cadastrado com sucesso!";
        }
    }
}
