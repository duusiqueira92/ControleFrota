
namespace DAL
{
    public class Acidente : Colisao
    {
        public Acidente(string tipoAcidente, string tipoPista, string marca, string modelo, string placa, int uf, string municipio,
                        string chassi, string cor, string ano, string pontosImpacto, string danos, int idBoletim)
        {
            this.tipoAcidente = tipoAcidente;
            this.tipoPista = tipoPista;
            this.marca = marca;
            this.modelo = modelo;
            this.uf = uf;
            this.municipio = municipio;
            this.chassi = chassi;
            this.cor = cor;
            this.ano = ano;
            this.pontosImpacto = pontosImpacto;
            this.danos = danos;
            this.idBoletim = idBoletim;
        }

        public Acidente()
        {

        }

        private int idBoletim;
        public int IdBoletim
        {
            get { return idBoletim; }
            set { idBoletim = value; }
        }


        private string tipoAcidente;
        public string TipoAcidente
        {
            get { return tipoAcidente; }
            set { tipoAcidente = value; }
        }

        private string tipoPista;
        public string TipoPista
        {
            get { return tipoPista; }
            set { tipoPista = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string placa;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private int uf;
        public int Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        private string municipio;
        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        private string chassi;
        public string Chassi
        {
            get { return chassi; }
            set { chassi = value; }
        }

        private string cor;
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        private string ano;
        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        private string pontosImpacto;
        public string PontosImpacto
        {
            get { return pontosImpacto; }
            set { pontosImpacto = value; }
        }

        private string danos;
        public string Danos
        {
            get { return danos; }
            set { danos = value; }
        }
    }
}
