
namespace DAL
{
    public class Acidente
    {
        public Acidente(string tipoAcidente, string tipoPista, string marca, string modelo, string placa, string uf, string municipio,
                        string chassi, string cor, string ano, string pontosImpacto, string danos)
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
        }

        public Acidente(string tipoAcidente, string tipoPista, string marca, string modelo, string placa, string uf, string municipio,
                        string chassi, string cor, string ano, string pontosImpacto, string danos, Colisao colisaoFrontal)
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
            this.colisaoFrontal = colisaoFrontal;
        }

        private Colisao colisaoFrontal;
        public Colisao ColisaoFrontal
        {
            get { return colisaoFrontal; }
            private set { colisaoFrontal = value; }
        }

        private Colisao colisaoFrontalDireita;
        public Colisao ColisaoFrontalDireita
        {
            get { return colisaoFrontalDireita; }
            private set { colisaoFrontalDireita = value; }
        }

        private Colisao colisaoFrontalEsquerda;
        public Colisao ColisaoFrontalEsquerda
        {
            get { return colisaoFrontalEsquerda; }
            private set { colisaoFrontalEsquerda = value; }
        }

        private Colisao colisaoTraseira;
        public Colisao ColisaoTraseira
        {
            get { return colisaoTraseira; }
            private set { colisaoTraseira = value; }
        }

        private Colisao colisaoTraseiraDireita;
        public Colisao ColisaoTraseiraDireita
        {
            get { return colisaoTraseiraDireita; }
            private set { colisaoTraseiraDireita = value; }
        }

        private Colisao colisaoTraseiraEsquerda;
        public Colisao ColisaoTraseiraEsquerda
        {
            get { return colisaoTraseiraEsquerda; }
            private set { colisaoTraseiraEsquerda = value; }
        }

        private Colisao colisaoLateralDireita;
        public Colisao ColisaoLateralDireita
        {
            get { return colisaoLateralDireita; }
            private set { colisaoLateralDireita = value; }
        }

        private Colisao colisaoLateralEsquerda;
        public Colisao ColisaoLateralEsquerda
        {
            get { return colisaoLateralEsquerda; }
            private set { colisaoLateralEsquerda = value; }
        }

        private Colisao colisaoLateralTrasDireita;
        public Colisao ColisaoLateralTrasDireita
        {
            get { return colisaoLateralTrasDireita; }
            private set { colisaoLateralTrasDireita = value; }
        }

        private Colisao colisaoLateralTrasEsquerda;
        public Colisao ColisaoLateralTrasEsquerda
        {
            get { return colisaoLateralTrasEsquerda; }
            private set { colisaoLateralTrasEsquerda = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
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

        private string uf;
        public string Uf
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
