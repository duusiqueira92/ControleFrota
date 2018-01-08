using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Colisao
    {
        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private bool colisaoFrontal;
        public bool ColisaoFrontal
        {
            get { return colisaoFrontal; }
            set { colisaoFrontal = value; }
        }

        private bool colisaoFrontalDireita;
        public bool ColisaoFrontalDireita
        {
            get { return colisaoFrontalDireita; }
            set { colisaoFrontalDireita = value; }
        }

        private bool colisaoFrontalEsquerda;
        public bool ColisaoFrontalEsquerda
        {
            get { return colisaoFrontalEsquerda; }
            set { colisaoFrontalEsquerda = value; }
        }

        private bool colisaoLateralDireita;
        public bool ColisaoLateralDireita
        {
            get { return colisaoLateralDireita; }
            set { colisaoLateralDireita = value; }
        }

        private bool colisaoLateralTrasDireita;
        public bool ColisaoLateralTrasDireita
        {
            get { return colisaoLateralTrasDireita; }
            set { colisaoLateralTrasDireita = value; }
        }

        private bool colisaoLateralEsquerda;
        public bool ColisaoLateralEsquerda
        {
            get { return colisaoLateralEsquerda; }
            set { colisaoLateralEsquerda = value; }
        }

        private bool colisaoLateralTrasEsquerda;
        public bool ColisaoLateraTraslEsquerda
        {
            get { return colisaoLateralTrasEsquerda; }
            set { colisaoLateralTrasEsquerda = value; }
        }

        private bool colisaoTraseira;
        public bool ColisaoTraseira
        {
            get { return colisaoTraseira; }
            set { colisaoTraseira = value; }
        }

        private bool colisaoTraseiraDireita;
        public bool ColisaoTraseiraDireita
        {
            get { return colisaoTraseiraDireita; }
            set { colisaoTraseiraDireita = value; }
        }

        private bool colisaoTraseiraEsquerda;
        public bool ColisaoTraseiraEsquerda
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
