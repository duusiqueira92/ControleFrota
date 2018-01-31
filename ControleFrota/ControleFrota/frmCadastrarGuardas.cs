using BLL;
using DAL;
using DAL.Interfaces;
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
    public partial class frmCadastrarGuardas : Form
    {
        public frmCadastrarGuardas()
        {
            InitializeComponent();
        }
        private readonly IGraduacaoRepository _graduacaoReposiroty;

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
        private void cmbGraduacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGraduacao.Text == "cadastrar")
            {
                Graduacao grad = new Graduacao();
                grad.Nome_graduacao = "3 classe";
                GraduacaoBLL novaGrad = new GraduacaoBLL(_graduacaoReposiroty);
                novaGrad.AdicionarFuncionario(grad);
            }
        }
    }
}
