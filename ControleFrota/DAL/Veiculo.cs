using DAL.Interfaces;

namespace DAL
{
    public class Veiculo
    {
        IEmplacamentoServices _emplacamentoServices;

        public Veiculo(IEmplacamentoServices emplacamentoServices)
        {
            _emplacamentoServices = emplacamentoServices;
        }

        private int id_veiculo;
        public int Id_veiculo
        {
            get { return id_veiculo; }
            set { id_veiculo = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string placa;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string anoFabricacao;
        public string AnoFabricacao
        {
            get { return anoFabricacao; }
            set { anoFabricacao = value; }
        }

        private string anoModelo;
        public string AnoModelo
        {
            get { return anoModelo; }
            set { anoModelo = value; }
        }

        private string municipio;
        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        private string renavam;
        public string Renavam
        {
            get { return renavam; }
            set { renavam = value; }
        }

        private string dpvat;
        public string Dpvat
        {
            get { return dpvat; }
            set { dpvat = value; }
        }

        private string licenciamento;
        public string Licenciamento
        {
            get { return licenciamento; }
            set { licenciamento = value; }
        }

        private string chassi;
        public string Chassi
        {
            get { return chassi; }
            set { chassi = value; }
        }

        private int uf;
        public int UF
        {
            get { return uf; }
            set { uf = value; }
        }

        private int combustivel;
        public int Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }

        private string prefixo;
        public string Prefixo
        {
            get { return prefixo; }
            set { prefixo = value; }
        }

        private string observacao;
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        private int km;
        public int Km
        {
            get { return km; }
            set { km = value; }
        }
        public bool ValidarPlaca()
        {
            _emplacamentoServices = new EmplacamentoServices();
            return _emplacamentoServices.ValidarPlaca(Placa);
        }
    }
}
