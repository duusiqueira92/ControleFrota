using DAL;
using DAL.Interfaces;
using System.Data;
using BLL.Interfaces;

namespace BLL
{
    public class GraduacaoServices : IGraduacaoServices
    {
        IGraduacaoRepository _graduacaoRepository;
       
        public string CadastrarGraduacao(Graduacao graduacao)
        {
            _graduacaoRepository = new GraduacaoRepository();
            _graduacaoRepository.CadastrarGraduacao(graduacao);
            return "Graduação cadastrada com sucesso!";
        }

        public DataTable CarregarGraduacao(Graduacao graduacao)
        {
            _graduacaoRepository = new GraduacaoRepository();
            return _graduacaoRepository.CarregarGraduacao(graduacao);
        }
    }
}
