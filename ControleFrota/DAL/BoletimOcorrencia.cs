using System;

namespace DAL
{
    public class BoletimOcorrencia
    {

        public BoletimOcorrencia()
        {

        }

        public BoletimOcorrencia(string data_ocorrencia, string hora_inicio, string seg_hora_inicio, string hora_termino,
            string seg_hora_termino, string km_inicio, string seg_km_inicio, string km_termino, string seg_km_termino,
            string tipoOcorrencia, string situacao, string bo_pc, int plantao, int equipe, int viatura, int motorista, int encarregado, string auxiliar,
            string endereco)
        {
            this.endereco = endereco;
            this.data_ocorrencia = data_ocorrencia;
            this.hora_inicio = hora_inicio;
            this.seg_hora_inicio = seg_hora_inicio;
            this.hora_termino = hora_termino;
            this.seg_hora_termino = seg_hora_termino;
            this.km_inicio = km_inicio;
            this.seg_km_inicio = seg_km_inicio;
            this.km_termino = km_termino;
            this.seg_km_termino = seg_km_termino;
            this.situacao = situacao;
            this.tipoOcorrencia = tipoOcorrencia;
            this.bo_pc = bo_pc;
            this.plantao = plantao;
            this.equipe = equipe;
            this.viatura = viatura;
            this.motorista = motorista;
            this.encarregado = encarregado;
            this.auxiliar = auxiliar;
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        private string data_ocorrencia;
        public string Data_Ocorrencia
        {
            get { return data_ocorrencia; }
            set { data_ocorrencia = value; }
        }

        private string hora_inicio;
        public string Hora_Inicio
        {
            get { return hora_inicio; }
            set { hora_inicio = value; }
        }

        private string seg_hora_inicio;
        public string Seg_Hora_Inicio
        {
            get { return seg_hora_inicio; }
            set { seg_hora_inicio = value; }
        }

        private string hora_termino;
        public string Hora_Termino
        {
            get { return hora_termino; }
            set { hora_termino = value; }
        }

        private string seg_hora_termino;
        public string Seg_Hora_Termino
        {
            get { return seg_hora_termino; }
            set { seg_hora_termino = value; }
        }

        //
        private string km_inicio;
        public string Km_Inicio
        {
            get { return km_inicio; }
            set { km_inicio = value; }
        }

        private string seg_km_inicio;
        public string Seg_Km_Inicio
        {
            get { return seg_km_inicio; }
            set { seg_km_inicio = value; }
        }

        private string km_termino;
        public string Km_Termino
        {
            get { return km_termino; }
            set { km_termino = value; }
        }

        private string seg_km_termino;
        public string Seg_Km_Termino
        {
            get { return seg_km_termino; }
            set { seg_km_termino = value; }
        }

        private string situacao;
        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }


        private string bo_pc;
        public string Bo_Pc
        {
            get { return bo_pc; }
            set { bo_pc = value; }
        }

        private int plantao;
        public int Plantao
        {
            get { return plantao; }
            set { plantao = value; }
        }


        private int equipe;
            public int Equipe
        {
            get { return equipe; }
            set { equipe = value; }
        }

        private int viatura;
        public int Viatura
        {
            get { return viatura; }
            set { viatura = value; }
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

        private string auxiliar;
        public string Auxiliar
        {
            get { return auxiliar; }
            set { auxiliar = value; }
        }

        private int? viaturaApoio;
        public int? Viatura_Apoio
        {
            get { return viaturaApoio; }
            set { viaturaApoio = value; }
        }

        private int? motoristaApoio;
        public int? MotoristaApoio
        {
            get { return motoristaApoio; }
            set { motoristaApoio = value; }
        }

        private int? encarregadoApoio;
        public int? EncarregadoApoio
        {
            get { return encarregadoApoio; }
            set { encarregadoApoio = value; }
        }

        private string auxiliarApoio;
        public string AuxiliarApoio
        {
            get { return auxiliarApoio; }
            set { auxiliarApoio = value; }
        }

        private string instituicaoApoio;
        public string InstituicaoApoio
        {
            get { return instituicaoApoio; }
            set { instituicaoApoio = value; }
        }

        private string motoristaInstituicao;
        public string MotoristaInstituicao
        {
            get { return motoristaInstituicao; }
            set { motoristaInstituicao = value; }
        }

        private string encarregadoInstituicao;
        public string EncarregadoInstituicao
        {
            get { return encarregadoInstituicao; }
            set { encarregadoInstituicao = value; }
        }

        private string tipoOcorrencia;
        public string TipoOcorrencia
        {
            get { return tipoOcorrencia; }
            set { tipoOcorrencia = value; }
        }
    }
}
