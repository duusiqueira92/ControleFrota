using DAL.Interfaces;

namespace DAL
{
    public class BoletimOcorrenciaServices : IBoletimOcorrenciaServices
    {
        private readonly IBoletimOcorrenciaRepository _boletimOcorrenciaRepository;
        public BoletimOcorrenciaServices(IBoletimOcorrenciaRepository boletimOcorrenciaRepository)
        {
            _boletimOcorrenciaRepository = boletimOcorrenciaRepository;
        }

        public string CadastrarBoletimOcorrencia(BoletimOcorrencia boletimOcorrencia)
        {
            _boletimOcorrenciaRepository.CadastrarBoletimOcorrencia(boletimOcorrencia);
            return "Boletim de Ocorrência cadastrado com sucesso!";
        }
    }
}
