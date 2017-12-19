using System;

namespace DAL
{
    public class BoletimOcorrencia
    {
        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private Equipe equipe;
        public Equipe Equipe
        {
            get { return equipe; }
            set { equipe = value; }
        }

        private Equipe equipeApoio;
        public Equipe EquipeApoio
        {
            get { return equipeApoio; }
            set { equipeApoio = value; }
        }

        private TipoOcorrencia tipoOcorrencia;
        public TipoOcorrencia TipoOcorrencia
        {
            get { return tipoOcorrencia; }
            set { tipoOcorrencia = value; }
        }
        private Apreensao objetoApreendido;
        public Apreensao ObjetoApreendido
        {
            get { return objetoApreendido; }
            set { objetoApreendido = value; }
        }

        private Colisao colisao;
        public Colisao Colisao
        {
            get { return colisao; }
            set { colisao = value; }
        }

        private Partes parte;
        public Partes Parte
        {
            get { return parte; }
            set { parte = value; }
        }

        private DateTime dataBoletim;
        public DateTime DataBoletim
        {
            get { return dataBoletim; }
            set { dataBoletim = value; }
        }
    }
}
