using System;

namespace DAL
{
    public class Equipe
    {

        public Equipe()
        {
                
        }
        public Equipe(int plantao, int equipe, int viatura, int km_inicio, int km_termino, string abastecido, double litros,
            string observacao, string data_ocupacao, int motorista, int encarregado)
        {
            this.plantao = plantao;
            this.setor = equipe;
            this.viatura = viatura;
            this.km_inicio = km_inicio;
            this.km_fim = km_termino;
            this.abastecido = abastecido;
            this.litros = litros;
            this.observacao = observacao;
            this.data_ocupacao = data_ocupacao;
            this.motorista = motorista;
            this.encarregado = encarregado;
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int plantao;
        public int Plantao
        {
            get { return plantao; }
            set { plantao = value; }
        }

        private int setor;
        public int Setor
        {
            get { return setor; }
            set { setor = value; }
        }

        private int motorista;
        public int Motorista
        {
            get { return motorista; }
            set { motorista = value; }
        }

        private int encarregado;
        public int Encarregado
        {
            get { return encarregado; }
            set { encarregado = value; }
        }

        private string data_ocupacao;
        public string Data_Ocupacao
        {
            get { return data_ocupacao; }
            set { data_ocupacao = value; }
        }

        private int viatura;
        public int Viatura
        {
            get { return viatura; }
            set { viatura = value; }
        }

        private int km_inicio;
        public int Km_Inicio
        {
            get { return km_inicio; }
            set { km_inicio = value; }
        }

        private int km_fim;
        public int Km_Fim
        {
            get { return km_fim; }
            set { km_fim = value; }
        }

        private string abastecido;
        public string Abastecido
        {
            get { return abastecido; }
            set { abastecido = value; }
        }

        private double litros;
        public double Litros
        {
            get { return litros; }
            set { litros = value; }
        }

        private string observacao;
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }
    }
}
