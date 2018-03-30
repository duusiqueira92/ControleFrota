using BLL;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class frmCadastrarArma : Form
    {
        Armamento armamento;
        IArmamentoServices _armamentoServices;
        int id;

        private void Limpar()
        {
            txtAcabamento.Text = String.Empty;
            txtAnoCadastro.Text = String.Empty;
            txtCalibre.Text = String.Empty;
            txtCidadeEmissao.Text = String.Empty;
            txtCompCano.Text = String.Empty;
            txtEspecie.Text = String.Empty;
            txtMarca.Text = String.Empty;
            txtModelo.Text = String.Empty;
            txtNumArma.Text = String.Empty;
            txtNumCadastro.Text = String.Empty;
            txtNumNF.Text = String.Empty;
            txtNumRegistro.Text = String.Empty;
            txtPaisFab.Text = String.Empty;
            txtQtdRaia.Text = String.Empty;
            txtSentRaia.Text = String.Empty;
            txtTipoAlma.Text = String.Empty;
            cmbCapTiros.SelectedIndex = -1;
            cmbFuncionamento.SelectedIndex = -1;
            cmbQtdCanos.SelectedIndex = -1;
            dtpDataEmissaoDoc.Value = DateTime.Now;
            dtpDataNF.Value = DateTime.Now;
            dtpDataValidade.Value = DateTime.Now;
        }

        public frmCadastrarArma(int id, string proprietario, string cpf, string rg)
        {
            InitializeComponent();
            this.id = id;
            lblCpf.Text = cpf;
            lblRg.Text = rg;
            lblProprietario.Text = proprietario;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string num_cadastro = txtAnoCadastro.Text + "/" + txtNumCadastro.Text;
            armamento = new Armamento(txtEspecie.Text, txtMarca.Text, txtModelo.Text, txtNumArma.Text, txtCalibre.Text, cmbCapTiros.Text,
                cmbFuncionamento.Text, txtAcabamento.Text, cmbQtdCanos.Text, txtCompCano.Text, txtTipoAlma.Text, txtQtdRaia.Text,
                txtSentRaia.Text, txtPaisFab.Text, txtNumNF.Text, dtpDataNF.Text, txtCidadeEmissao.Text, dtpDataEmissaoDoc.Text, txtNumRegistro.Text,
                dtpDataValidade.Text, num_cadastro, id);
            _armamentoServices = new ArmamentoServices();
            MessageBox.Show(_armamentoServices.CadastrarArmamento(armamento));
              
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
