using BLL;
using System;
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
    public partial class frmCadastrarArma : Form
    {
        public frmCadastrarArma()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ArmamentoBLL cadArma = new ArmamentoBLL();
            cadArma.salvarArma(0, txtModelo.Text, txtModelo.Text, txtNumArma.Text);
        }
    }
}
