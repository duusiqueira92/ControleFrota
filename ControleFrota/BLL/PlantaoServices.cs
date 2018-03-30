using DAL;
using DAL.Interfaces;
using System;
using BLL.Interfaces;

namespace BLL
{
    public class PlantaoServices : IPlantaoServices
    {
        IPlantaoRepository _plantaoRepository;

        public PlantaoServices(IPlantaoRepository plantaoRepository)
        {
            _plantaoRepository = plantaoRepository;
        }
        public string CadastrarPlantao(Plantao plantao)
        {
            try
            {
                _plantaoRepository.CadastrarPlantao(plantao);
                return "Plantão cadastrado com sucesse!";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
