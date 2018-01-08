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
    public partial class frmGerenciarPlantao : Form
    {
        public frmGerenciarPlantao()
        {
            InitializeComponent();
        }

        private void btnNovoPlantao_Click(object sender, EventArgs e)
        {
            frmCadastrarPlantao novoPlantao = new frmCadastrarPlantao();
            novoPlantao.ShowDialog();
        }
    }
}
