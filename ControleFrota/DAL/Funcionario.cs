using DAL.Interfaces;
using System;

namespace DAL
{
    public class Funcionario : Pessoa
    {
        private readonly ICpfServices _cpfServices;
        private readonly IPhoneServices _phoneServices;

        public Funcionario(ICpfServices cpfServices, IPhoneServices phoneServices) : 
                           base(cpfServices, phoneServices)
        {
            _cpfServices = cpfServices;
            _phoneServices = phoneServices;
        }

        private string pis;
        public string Pis
        {
            get { return pis; }
            set { pis = value; }
        }

        private Graduacao graduacao;
        public Graduacao Graduacao
        {
            get { return graduacao; }
            set { graduacao = value; }
        }

        private DateTime dataContratacao;
        public DateTime DataContratacao
        {
            get { return dataContratacao; }
            set { dataContratacao = value; }
        }

        private DateTime validadeRegistro;
        public DateTime ValidadeRegistro
        {
            get { return validadeRegistro; }
            set { validadeRegistro = value; }
        }
    }
}
