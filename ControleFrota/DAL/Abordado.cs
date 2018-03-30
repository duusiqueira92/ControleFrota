using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Abordado
    {
        public Abordado()
        {

        }

        public Abordado(string nome_abordado, string rg, string endereco, string passagem, string artigo, int equipe)
        {
            this.nome_abordado = nome_abordado;
            this.endereco = endereco;
            this.rg = rg;
            this.passagem = passagem;
            this.artigo = artigo;
            this.equipe = equipe;
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nome_abordado;
        public string Nome_Abordado
        {
            get { return nome_abordado; }
            set { nome_abordado = value; }
        }

        private string rg;
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private string passagem;
        public string Passagem
        {
            get { return passagem; }
            set { passagem = value; }
        }

        private string artigo;
        public string Artigo
        {
            get { return artigo; }
            set { artigo = value; }
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
