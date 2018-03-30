using BLL;
using DAL;
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
    public partial class frmCadNaturezaOcorrencia : Form
    {
        NatOcorrenciaServices novaNatOcorrencia;
        NatOcorrencia natOcorrencia;

        public frmCadNaturezaOcorrencia()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novaNatOcorrencia = new NatOcorrenciaServices();
                natOcorrencia.Id = Convert.ToInt32(txtCodigo.Text);
                natOcorrencia.Nome = txtNome.Text;
                natOcorrencia.Descricao = txtDescricao.Text;

                MessageBox.Show(novaNatOcorrencia.CadastarNaturezaOcorrencia(natOcorrencia));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ! " + ex.Message);
            }
        }
    }
}
