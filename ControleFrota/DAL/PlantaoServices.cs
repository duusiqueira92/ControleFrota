using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlantaoServices : IPlantaoServices
    {
        private readonly IPlantaoRepository _plantaoRepository;

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
