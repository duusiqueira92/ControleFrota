using DAL.Interfaces;

namespace DAL
{
    public class Veiculo
    {
        private readonly IEmplacamentoServices _emplacamentoServices;

        public Veiculo(IEmplacamentoServices emplacamentoServices)
        {
            _emplacamentoServices = emplacamentoServices;
        }

        private int id_veiculo;
        public int Id_veiculo
        {
            get { return id_veiculo; }
            private set { id_veiculo = value; }
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

        private string ano;
        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        private string prefixo;
        public string Prefixo
        {
            get { return prefixo; }
            set { prefixo = value; }
        }

        private int km;
        public int Km
        {
            get { return km; }
            set { km = value; }
        }
        public bool ValidarPlaca()
        {
            return _emplacamentoServices.ValidarPlaca(Placa);
        }
    }
}
