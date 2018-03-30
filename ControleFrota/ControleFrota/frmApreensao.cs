using BLL;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class frmApreensao : Form
    {
        IApreensoesServices _apreensoesServices;
        Apreensao apreensao;
        List<Apreensao> objetos = new List<Apreensao>();
        int idBoletim, i;
        public frmApreensao(int _idBoletim)
        {
            idBoletim = _idBoletim;
            InitializeComponent();
        }
        
        private bool Validar()
        {
            if (txtNumeracao.Text == String.Empty)
            {
                MessageBox.Show("Preencher o campo Numeração!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumeracao.Focus();
                return false;
            }

            if (cmbObjeto.SelectedIndex == -1)
            {
                MessageBox.Show("Preencher o campo Objeto!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbObjeto.Focus();
                return false;
            }

            return true;
        }

        private void SalvarApreensao()
        {
            if (txtNumeracao.Text != String.Empty)
            {
                apreensao = new Apreensao(txtModelo.Text, txtCor.Text, Convert.ToDouble(txtQuantidade.Text), txtNumeracao.Text, idBoletim);
                apreensao.CategoriaObjeto = Convert.ToInt32(cmbObjeto.SelectedValue);
                apreensao.Observacoes = txtEspecificacao.Text;
                objetos.Add(apreensao);
            }
            if (objetos.Count > 0)
            {
                _apreensoesServices = new ApreensaoServices();
                _apreensoesServices.CadastrarApreensao(objetos);
            }
        }

        private void RetornarObjetos()
        {
            _apreensoesServices = new ApreensaoServices();
            cmbObjeto.DataSource = _apreensoesServices.RetornarObjetos();
            cmbObjeto.DisplayMember = "nome";
            cmbObjeto.ValueMember = "id";
            cmbObjeto.SelectedIndex = -1;
        }

        private void btnNovoObjeto_Click(object sender, EventArgs e)
        {
            apreensao = new Apreensao(txtModelo.Text, txtCor.Text, Convert.ToDouble(txtQuantidade.Text), txtNumeracao.Text, idBoletim);
            apreensao.CategoriaObjeto = Convert.ToInt32(cmbObjeto.SelectedValue);
            apreensao.Observacoes = txtEspecificacao.Text;
            
            var resposta = MessageBox.Show("Deseja cadastrar uma nova apreensão para o mesmo B.O.?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                i += 1;
                objetos.Add(apreensao);
            }
        }

        private void frmApreensao_Load(object sender, EventArgs e)
        {
            RetornarObjetos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrarObjeto cadastrarObjeto = new frmCadastrarObjeto();
            cadastrarObjeto.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                SalvarApreensao();
            }
        }
    }
}
