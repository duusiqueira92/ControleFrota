using DAL.Interfaces;

namespace DAL
{
    public class Funcionario : Pessoa
    {
        private readonly ICpfServices _cpfServices;

        public Funcionario()
        {

        }

        public Funcionario(ICpfServices cpfServices) : 
                           base(cpfServices)
        {
            _cpfServices = cpfServices;
        }

        public Funcionario(string nome, string rua, string numero, string bairro, string cidade,
            int uf, string cep, string celular, string numCnh, string regCnh,
            int categoria, string validade, string pis, string rg, int orgEmissor, int rgUf, string emissaoRg, string cpf,
            string dataNascimento, string estadoCivil, string filhos, string escolaridade, string conclusaoEscolaridade,
            string instituicao, string tipoSanguineo, string restricao, string nomePai, string nomeMae,
            string rf, string dataAdmissao, string qra, int graduacao, ICpfServices cpfServices) : base(cpfServices)
        {
            this.Nome = nome;
            this.Rua = rua;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = uf;
            this.Cep = cep;
            this.Celular = celular;
            this.Cnh = numCnh;
            this.RegCnh = regCnh;
            this.Categoria = categoria;
            this.Validade_cnh = validade;
            this.pis = pis;
            this.Rg = rg;
            this.OrgaoEmissor = orgEmissor;
            this.Rg_Uf = rgUf;
            this.Emissao_Rg = emissaoRg;
            this.Cpf = cpf;
            this.DataNascimento = dataNascimento;
            this.Estado_Civil = estadoCivil;
            this.Filhos = filhos;
            this.Escolaridade = escolaridade;
            this.Conclusao_Escolar = conclusaoEscolaridade;
            this.Instituicao = instituicao;
            this.Tipo_Sanguineo = tipoSanguineo;
            this.Restricao = restricao;
            this.Nome_Pai = nomePai;
            this.Nome_Mae = nomeMae;
            this.Rf = rf;
            this.DataContratacao = dataAdmissao;
            this.Qra = qra;
            this.Graduacao = graduacao;
        }

        private string pis;
        public string Pis
        {
            get { return pis; }
            set { pis = value; }
        }

        private int graduacao;
        public int Graduacao
        {
            get { return graduacao; }
            set { graduacao = value; }
        }

        private int posicao;
        public int Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

        private string dataContratacao;
        public string DataContratacao
        {
            get { return dataContratacao; }
            set { dataContratacao = value; }
        }

        private string validadeRegistro;
        public string ValidadeRegistro
        {
            get { return validadeRegistro; }
            set { validadeRegistro = value; }
        }

        private string qra;
        public string Qra
        {
            get { return qra; }
            set { qra = value; }
        }

        private string filhos;
        public string Filhos
        {
            get { return filhos; }
            set { filhos = value; }
        }

        private string escolaridade;
        public string Escolaridade
        {
            get { return escolaridade; }
            set { escolaridade = value; }
        }

        private string conclusao_escolar;
        public string Conclusao_Escolar
        {
            get { return conclusao_escolar; }
            set { conclusao_escolar = value; }
        }

        private string instituicao;
        public string Instituicao
        {
            get { return instituicao; }
            set { instituicao = value; }
        }

        private string formacao;
        public string Formacao
        {
            get { return formacao; }
            set { formacao = value; }
        }

        private string conclusao_superior;
        public string Conclusao_Superior
        {
            get { return conclusao_superior; }
            set { conclusao_superior = value; }
        }

        private string tipo_sanguineo;
        public string Tipo_Sanguineo
        {
            get { return tipo_sanguineo; }
            set { tipo_sanguineo = value; }
        }

        private string restricao;
        public string Restricao
        {
            get { return restricao; }
            set { restricao = value; }
        }

        private string observacao;
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        private string rf;
        public string Rf
        {
            get { return rf; }
            set { rf = value; }
        }

        private string zona;
        public string Zona
        {
            get { return zona; }
            set { zona = value; }
        }

        private string titulo_eleitor;
        public string Titulo_Eleitor
        {
            get { return titulo_eleitor; }
            set { titulo_eleitor = value; }
        }

        private string cidade_titulo;
        public string Cidade_Titulo
        {
            get { return cidade_titulo; }
            set { cidade_titulo = value; }
        }

        private int estado_titulo;
        public int Estado_Titulo
        {
            get { return estado_titulo; }
            set { estado_titulo = value; }
        }

        private string sessao;
        public string Sessao
        {
            get { return sessao; }
            set { sessao = value; }
        }

        private string emissao_titulo;
        public string Emissao_Titulo
        {
            get { return emissao_titulo; }
            set { emissao_titulo = value; }
        }

        private string estado_civil;
        public string Estado_Civil
        {
            get { return estado_civil; }
            set { estado_civil = value; }
        }

        private int uf_naturalidade;
        public int Uf_Naturalidade
        {
            get { return uf_naturalidade; }
            set { uf_naturalidade = value; }
        }
    }
}
