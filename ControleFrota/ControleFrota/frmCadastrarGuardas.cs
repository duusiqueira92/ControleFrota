﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class frmCadastrarGuardas : Form
    {
        public frmCadastrarGuardas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnArma_Click_1(object sender, EventArgs e)
        {
            frmCadastrarArma frmCadArma = new frmCadastrarArma();
            frmCadArma.ShowDialog();
        }

        private void btnColete_Click(object sender, EventArgs e)
        {
            frmCadastrarColete frmCadColete = new frmCadastrarColete();
            frmCadColete.ShowDialog();
        }
    }
}
