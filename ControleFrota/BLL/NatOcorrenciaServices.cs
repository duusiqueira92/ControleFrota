using BLL.Interfaces;
using DAL;
using DAL.Interfaces;

namespace BLL
{
    public class NatOcorrenciaServices : INatOcorrenciaServices
    {
        INatOcorrenciaRepository _natOcorrenciaRepository;

        public string CadastarNaturezaOcorrencia(NatOcorrencia natOcorrencia)
        {
            _natOcorrenciaRepository = new NatOcorrenciaRepository();
            _natOcorrenciaRepository.CadastrarNatOcorrencia(natOcorrencia);
            return "Natureza de ocorrência cadastrada com sucesso!";
        }
    }
}
