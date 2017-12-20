using DAL.Interfaces;

namespace DAL
{
    public class Partes : Pessoa
    {
        private readonly ICpfServices _cpfServices;
        private readonly IPhoneServices _phoneServices;

        public Partes(ICpfServices cpfServices, IPhoneServices phoneServices) :
                      base(cpfServices, phoneServices)
        {
            _cpfServices = cpfServices;
            _phoneServices = phoneServices;
        }

        private string nomePai;
        public string NomePai
        {
            get { return nomePai; }
            set { nomePai = value; }
        }

        private string nomeMae;
        public string NomeMae
        {
            get { return nomeMae; }
            set { nomeMae = value; }
        }

        private string naturalidade;
        public string Naturalidade
        {
            get { return naturalidade; }
            set { naturalidade = value; }
        }

        private string nacionalidade;
        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }

        private string versaoParte;
        public string VersaoParte
        {
            get { return versaoParte; }
            set { versaoParte = value; }
        }
    }
}
