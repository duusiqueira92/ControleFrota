using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Colisao
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int colisaoFrontal;
        public int ColisaoFrontal
        {
            get { return colisaoFrontal; }
            set { colisaoFrontal = value; }
        }

        private int colisaoFrontalDireita;
        public int ColisaoFrontalDireita
        {
            get { return colisaoFrontalDireita; }
            set { colisaoFrontalDireita = value; }
        }

        private int colisaoFrontalEsquerda;
        public int ColisaoFrontalEsquerda
        {
            get { return colisaoFrontalEsquerda; }
            set { colisaoFrontalEsquerda = value; }
        }

        private int colisaoLateralDireita;
        public int ColisaoLateralDireita
        {
            get { return colisaoLateralDireita; }
            set { colisaoLateralDireita = value; }
        }

        private int colisaoLateralTrasDireita;
        public int ColisaoLateralTrasDireita
        {
            get { return colisaoLateralTrasDireita; }
            set { colisaoLateralTrasDireita = value; }
        }

        private int colisaoLateralEsquerda;
        public int ColisaoLateralEsquerda
        {
            get { return colisaoLateralEsquerda; }
            set { colisaoLateralEsquerda = value; }
        }

        private int colisaoLateralTrasEsquerda;
        public int ColisaoLateralTrasEsquerda
        {
            get { return colisaoLateralTrasEsquerda; }
            set { colisaoLateralTrasEsquerda = value; }
        }

        private int colisaoTraseira;
        public int ColisaoTraseira
        {
            get { return colisaoTraseira; }
            set { colisaoTraseira = value; }
        }

        private int colisaoTraseiraDireita;
        public int ColisaoTraseiraDireita
        {
            get { return colisaoTraseiraDireita; }
            set { colisaoTraseiraDireita = value; }
        }

        private int colisaoTraseiraEsquerda;
        public int ColisaoTraseiraEsquerda
        {
            get { return colisaoTraseiraEsquerda; }
            set { colisaoTraseiraEsquerda = value; }
        }

        private string observacoes;
        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }
    }
}
