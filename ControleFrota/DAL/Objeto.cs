namespace DAL
{
    public class Objeto
    {
        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string nomeObjeto;
        public string NomeObjeto
        {
            get { return nomeObjeto; }
            set { nomeObjeto = value; }
        }
    }
}
