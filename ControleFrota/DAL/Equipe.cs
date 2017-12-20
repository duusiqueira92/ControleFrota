namespace DAL
{
    public class Equipe
    {
        public Equipe(string nomeEquipe, Funcionario motorista, Veiculo viatura)
        {
            this.nomeEquipe = nomeEquipe;
            this.motorista = motorista;
            this.viatura = viatura;
        }

        public Equipe(string nomeEquipe, Funcionario motorista, Funcionario encarregado, Veiculo viatura)
        {
            this.nomeEquipe = nomeEquipe;
            this.motorista = motorista;
            this.encarregado = encarregado;
            this.viatura = viatura;
        }

        public Equipe(string nomeEquipe, Funcionario motorista, Funcionario encarregado, 
                      Funcionario auxiliar, Veiculo viatura)
        {
            this.nomeEquipe = nomeEquipe;
            this.motorista = motorista;
            this.encarregado = encarregado;
            this.auxiliar = auxiliar;
            this.viatura = viatura;
        }

        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string nomeEquipe;
        public string NomeEquipe
        {
            get { return nomeEquipe; }
            set { nomeEquipe = value; }
        }

        private Funcionario motorista;
        public Funcionario Motorista
        {
            get { return motorista; }
            set { motorista = value; }
        }

        private Funcionario encarregado;
        public Funcionario Encarregado
        {
            get { return encarregado; }
            set { encarregado = value; }
        }

        private Funcionario auxiliar;
        public Funcionario Auxiliar
        {
            get { return auxiliar; }
            set { auxiliar = value; }
        }

        private Veiculo viatura;
        public Veiculo Viatura
        {
            get { return viatura; }
            set { viatura = value; }
        }
    }
}
