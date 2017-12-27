using System;

namespace DAL
{
    public class Plantao
    {
        public Plantao(string nomePlantao, DateTime horaInicio, DateTime horaTermino)
        {
            this.nomePlantao = nomePlantao;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nomePlantao;
        public string NomePlantao
        {
            get { return nomePlantao; }
            set { nomePlantao = value; }
        }

        private DateTime horaInicio;
        public DateTime HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        private DateTime horaTermino;
        public DateTime HoraTermino
        {
            get { return horaTermino; }
            set { horaTermino = value; }
        }
    }
}
