using DAL.Interfaces;
using DAL;
using BLL.Interfaces;

namespace BLL
{
    public class TipoOcorrenciaServices : ITipoOcorrenciaServices
    {
        ITipoOcorrenciaRepository _tipoOcorrenciaRepository;
        public TipoOcorrenciaServices(ITipoOcorrenciaRepository tipoOcorrenciaRepository)
        {
            _tipoOcorrenciaRepository = tipoOcorrenciaRepository;
        }

        public string CadastrarTipoOcorrencia(TipoOcorrencia tipoOcorrencia)
        {
            _tipoOcorrenciaRepository.CadastrarTipoOcorrencia(tipoOcorrencia);
            return "Ocorrência cadastrada com sucesso!";
        }
    }
}
