using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GraduacaoBLL
    {
        private readonly IGraduacaoRepository _graduacaoReposiroty;
        GraduacaoServices novaGraduacao;

        public GraduacaoBLL(IGraduacaoRepository graduacaoReposiroty)
        {
            _graduacaoReposiroty = graduacaoReposiroty;
        }
        public void AdicionarFuncionario(Graduacao graduacao)
        {
            novaGraduacao = new GraduacaoServices(_graduacaoReposiroty);
            novaGraduacao.CadastrarGraduacao(graduacao);


        }
    }
}
