using DAL.Interfaces;
using System;

namespace DAL
{
    public abstract class Pessoa
    {
        ICpfServices _cpfServices;

        public Pessoa(string nome, string nome_pai, string nome_mae, string telefone, string rua, string bairro, string cidade,
            string numero, int uf, string rg, string dataNascimento, int orgEmissor, int ufOrgEmissor)
        {
            this.nome = nome;
            this.nome_pai = nome_pai;
            this.nome_mae = nome_mae;
            this.telefone = telefone;
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
            this.numero = numero;
            this.estado = uf;
            this.rg = rg;
            this.dataNascimento = dataNascimento;
            this.orgaoEmissor = orgEmissor;
            this.rg_uf = ufOrgEmissor;
        }

        public Pessoa(ICpfServices cpfServices)
        {
            _cpfServices = cpfServices;
        }

        public Pessoa()
        {
              
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
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
            get { return rua; }
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

        private int estado;
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string cep;
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        private string complemento;
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        private string rg;
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private int orgaoEmissor;
        public int OrgaoEmissor
        {
            get { return orgaoEmissor; }
            set { orgaoEmissor = value; }
        }

        private int rg_uf;
        public int Rg_Uf
        {
            get { return rg_uf; }
            set { rg_uf = value; }
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

        private int categoria;
        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private string validade_cnh;
        public string Validade_cnh
        {
            get { return validade_cnh; }
            set { validade_cnh = value; }
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

        private string emissao_rg;
        public string Emissao_Rg
        {
            get { return emissao_rg; }
            set { emissao_rg = value; }
        }

        private string nome_pai;
        public string Nome_Pai
        {
            get { return nome_pai; }
            set { nome_pai = value; }
        }

        private string nome_mae;
        public string Nome_Mae
        {
            get { return nome_mae; }
            set { nome_mae = value; }
        }

        private string naturalidade;
        public string Naturalidade
        {
            get { return naturalidade; }
            set { naturalidade = value; }
        }

        

        private string dataNascimento;
        public string DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public bool Validacao()
        {
            _cpfServices = new CpfServices();
            return _cpfServices.Validacao(Cpf);
        }
    }
}
