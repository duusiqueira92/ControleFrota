using System;

namespace DAL
{
    public class Colete
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int agente;
        public int Agente
        {
            get { return agente; }
            set { agente = value; }
        }

        private string numSerie;
        public string NumSerie
        {
            get { return numSerie; }
            set { numSerie = value; }
        }

        private string nivel;
        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        private string numLote;
        public string NumLote
        {
            get { return numLote; }
            set { numLote = value; }
        }
        private string numCA;
        public string NumCA
        {
            get { return numCA; }
            set { numCA = value; }
        }

        private string tamanho;
        public string Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        private string proprietario;
        public string Proprietario
        {
            get { return proprietario; }
            set { proprietario = value; }
        }

        private string dataFabricacao;
        public string DataFabricacao
        {
            get { return dataFabricacao; }
            set { dataFabricacao = value; }
        }
    }
}
