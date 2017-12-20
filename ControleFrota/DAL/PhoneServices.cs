using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhoneServices : IPhoneServices
    {
        public bool ValidarCelular(string celular)
        {
            return celular.Length == 14;
        }

        public bool ValidarTelefone(string telefone)
        {
            return telefone.Length == 13;
        }
    }
}
