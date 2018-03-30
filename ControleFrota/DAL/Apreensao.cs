namespace DAL
{
    public class Apreensao
    {
        public Apreensao()
        {

        }

        public Apreensao(string modeloObjeto, string corObjeto, double quantidade, string numObjeto, int idBoletim)
        {
            this.modeloObjeto = modeloObjeto;
            this.corObjeto = corObjeto;
            this.quantidade = quantidade;
            this.numObjeto = numObjeto;
            this.idBoletim = idBoletim;
        }

        private int idBoletim;
        public int IdBoletim
        {
            get { return idBoletim; }
            set { idBoletim = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string modeloObjeto;
        public string ModeloObjeto
        {
            get { return modeloObjeto; }
            set { modeloObjeto = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private int categoriaObjeto;
        public int CategoriaObjeto
        {
            get { return categoriaObjeto; }
            set { categoriaObjeto = value; }
        }

        private string numObjeto;
        public string NumObjeto
        {
            get { return numObjeto; }
            set { numObjeto = value; }
        }

        private string corObjeto;
        public string CorObjeto
        {
            get { return corObjeto; }
            set { corObjeto = value; }
        }

        private double quantidade;
        public double Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private string observacoes;
        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }
    }
}
