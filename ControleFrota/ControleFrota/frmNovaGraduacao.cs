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
    public partial class frmNovaGraduacao : Form
    {
        public frmNovaGraduacao()
        {
            InitializeComponent();
        }
        
        Graduacao grad;
        BLL.GraduacaoServices novaGraduacao;

        private void btnFechar_Click(object sender, EventArgs e)
        {
           var resp = MessageBox.Show("Deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                this.Close();   
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                grad = new Graduacao();
                grad.Nome_graduacao = txtNome.Text;
                grad.Descricao = txtDescricao.Text;
                novaGraduacao = new BLL.GraduacaoServices();

                MessageBox.Show(novaGraduacao.CadastrarGraduacao(grad), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar graduação! " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
