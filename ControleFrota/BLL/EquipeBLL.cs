using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class EquipeBLL
    {
        private readonly IEquipeServices _equipeServices;
        
        public void CadastrarEquipe(Equipe equipe)
        {
            _equipeServices.CadastrarEquipe(equipe);
        }
    }
}
