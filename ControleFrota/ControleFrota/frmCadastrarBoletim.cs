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
    public partial class frmCadastrarBoletim : Form
    {
        public frmCadastrarBoletim()
        {
            InitializeComponent();
        }

        private void frmInformarEquipes_Load(object sender, EventArgs e)
        {

        }

        private void btnNovaParte_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja cadastrar uma nova parte para o mesmo B.O.?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("outra parte!");
            }
        }
    }
}
