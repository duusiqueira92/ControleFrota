using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TipoOcorrenciaServices : ITipoOcorrenciaServices
    {
        private readonly ITipoOcorrenciaRepository _tipoOcorrenciaRepository;
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
