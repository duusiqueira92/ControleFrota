using System;
using DAL.Interfaces;

namespace DAL
{
    public class EquipeServices : IEquipeServices
    {
        private readonly IEquipeRepository _equipeRepository;
        public EquipeServices(IEquipeRepository equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }
        public string CadastrarEquipe(Equipe equipe)
        {
            try
            {
                _equipeRepository.CadastrarEquipe(equipe);
                return "Equipe cadastrada com sucesso!";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
