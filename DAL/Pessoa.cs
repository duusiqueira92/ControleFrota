using DAL.Interfaces;
using System;

namespace DAL
{
    public abstract class Pessoa
    {
        private readonly ICpfServices _cpfServices;
        private readonly IPhoneServices _phoneServices;

        public Pessoa(ICpfServices cpfServices, IPhoneServices phoneServices)
        {
            _cpfServices = cpfServices;
            _phoneServices = phoneServices;
        }

        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string rua;
        public string Rua
        {
            get { return nome; }
            set { rua = value; }
        }

        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private string cidade;
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        private string rg;
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private string orgaoEmissor;
        public string OrgaoEmissor
        {
            get { return orgaoEmissor; }
            set { orgaoEmissor = value; }
        }

        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string cnh;
        public string Cnh
        {
            get { return cnh; }
            set { cnh = value; }
        }

        private string regCnh;
        public string RegCnh
        {
            get { return regCnh; }
            set { regCnh = value; }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string celular;
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public bool Validacao()
        {
            return _cpfServices.Validacao(Cpf);
        }

        public bool ValidaTelefone()
        {
            return _phoneServices.ValidarTelefone(Telefone) && 
                   _phoneServices.ValidarCelular(Celular);
        }
    }
}
