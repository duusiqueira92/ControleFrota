using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TipoOcorrencia
    {
        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string naturezaOcorrencia;
        public string NaturezaOcorrencia
        {
            get { return naturezaOcorrencia; }
            set { naturezaOcorrencia = value; }
        }
    }
}
