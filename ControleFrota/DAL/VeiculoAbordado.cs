using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VeiculoAbordado
    {
        public VeiculoAbordado(string condutor, string marca, string modelo, string placa, string endereco, int equipe)
        {
            this.condutor = condutor;
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.endereco = endereco;
            this.equipe = equipe;
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string condutor;
        public string Condutor
        {
            get { return condutor; }
            set { condutor = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string placa;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private int equipe;
        public int Equipe
        {
            get { return equipe; }
            set { equipe = value; }
        }
    }
}
