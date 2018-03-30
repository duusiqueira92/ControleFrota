using DAL.Interfaces;
using System;

namespace DAL
{
    public class Partes : Pessoa
    {
        private readonly ICpfServices _cpfServices;

        public Partes(string nome, string nomePai, string nomeMae, string telefone, string rua, string bairro, string cidade, 
            string numero, int uf, string rg, string dataNascimento,int orgEmissor, int ufOrgEmissor, string tipoParte, 
            string conduzido, string naturalidade,string nacionalidade, int boletim_ocorrencia) : 
            base(nome, nomePai, nomeMae, telefone, rua, bairro, cidade, numero, uf, rg, dataNascimento, orgEmissor, ufOrgEmissor)
        {
            Nome = nome;
            Nome_Pai = nomePai;
            Nome_Mae = nomeMae;
            Telefone = telefone;
            Rua = rua;
            Bairro = bairro;
            Rg = rg;
            DataNascimento = dataNascimento;
            this.boletim_ocorrencia = boletim_ocorrencia;
            this.nacionalidade = nacionalidade;
        }

        public Partes(ICpfServices cpfServices) :
                      base(cpfServices)
        {
            _cpfServices = cpfServices;
        }

        private int boletim_ocorrencia;
        public int Boletim_Ocorrencia
        {
            get { return boletim_ocorrencia; }
            set { boletim_ocorrencia = value; }
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

        private string localTrabalho;
        public string Local_Trabalho
        {
            get { return localTrabalho; }
            set { localTrabalho = value; }
        }

        private string numeroTrabalho;
        public string Numero_Trabalho
        {
            get { return numeroTrabalho; }
            set { numeroTrabalho = value; }
        }

        private string bairroTrabalho;
        public string Bairro_Trabalho
        {
            get { return bairroTrabalho; }
            set { bairroTrabalho = value; }
        }

        private string cidadeTrabalho;
        public string Cidade_Trabalho
        {
            get { return cidadeTrabalho; }
            set { cidadeTrabalho = value; }
        }

        private string profissao;
        public string Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }

        private string tel_comercial;
        public string Tel_Comercial
        {
            get { return tel_comercial; }
            set { tel_comercial = value; }
        }

        private string conduzido;
        public string Conduzido
        {
            get { return conduzido; }
            set { conduzido = value; }
        }

        private string tipoParte;
        public string TipoParte
        {
            get { return tipoParte; }
            set { tipoParte = value; }
        }
    }
}
