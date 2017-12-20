using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DAL
{
    public class Plantao
    {
        public Plantao(Equipe setorDiurnoA, Equipe setorDiurnoB, Equipe setorNoturnoA,
            Equipe setorNoturnoB, Equipe apoioA, Equipe apoioB)
        {
            this.apoioA = apoioA;
            this.apoioB = apoioB;
            this.setorDiurnoA = setorDiurnoA;
            this.setorDiurnoB = setorDiurnoB;
            this.setorNoturnoA = setorNoturnoA;
            this.setorNoturnoB = setorNoturnoB;
        }

        private Equipe setorDiurnoA;
        public Equipe SetorDiurnoA
        {
            get { return setorDiurnoA; }
            set { setorDiurnoA = value; }
        }

        private Equipe setorDiurnoB;
        public Equipe SetorDiurnoB
        {
            get { return setorDiurnoB; }
            set { setorDiurnoB = value; }
        }

        private Equipe setorNoturnoA;
        public Equipe SetorNoturnoA
        {
            get { return setorNoturnoA; }
            set { setorNoturnoA = value; }
        }

        private Equipe setorNoturnoB;
        public Equipe SetorNoturnoB
        {
            get { return setorNoturnoB; }
            set { setorNoturnoB = value; }
        }

        private Equipe apoioA;
        public Equipe ApoioA
        {
            get { return apoioA; }
            set { apoioA = value; }
        }

        private Equipe apoioB;
        public Equipe ApoioB
        {
            get { return apoioB; }
            set { apoioB = value; }
        }
    }
}
