﻿using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Graduacao
    {

        private int id_graduacao;
        public int Id_graduacao
        {
            get { return id_graduacao; }
            private set { id_graduacao = value; }
        }

        private string nome_graduacao;
        public string Nome_graduacao
        {
            get { return nome_graduacao; }
            set { nome_graduacao = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
