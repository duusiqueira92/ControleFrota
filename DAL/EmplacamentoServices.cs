using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmplacamentoServices
    {
        public bool ValidarPlaca(string placa)
        {
            return placa.Length == 7;
        }
    }
}
