namespace DAL
{
    public class TipoParte
    {
        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string nomeParte;
        public string NomeParte
        {
            get { return nomeParte; }
            set { nomeParte = value; }
        }
    }
}
