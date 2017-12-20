namespace DAL
{
    public class Apreensao
    {
        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string modeloObjeto;
        public string ModeloObjeto
        {
            get { return modeloObjeto; }
            set { modeloObjeto = value; }
        }

        private Objeto categoriaObjeto;
        public Objeto CategoriaObjeto
        {
            get { return categoriaObjeto; }
            private set { categoriaObjeto = value; }
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
