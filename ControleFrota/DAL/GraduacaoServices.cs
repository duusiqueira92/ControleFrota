using DAL.Interfaces;
using System;

namespace DAL
{
    public class GraduacaoServices : IGraduacaoServices
    {
        private readonly IGraduacaoRepository _graduacaoRepository;
        public GraduacaoServices(IGraduacaoRepository graduacaoRepository)
        {
            _graduacaoRepository = graduacaoRepository;
        }
        public string CadastrarGraduacao(Graduacao graduacao)
        {
            _graduacaoRepository.CadastrarGraduacao(graduacao);
            return "Graduação cadastrada com sucesso!";
        }
    }
}
