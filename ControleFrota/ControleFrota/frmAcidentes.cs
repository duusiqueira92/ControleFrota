using BLL;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class frmAcidentes : Form
    {
        IAcidenteRepository _acidenteRespository;
        IAcidenteServices _acidenteServices;
        Colisao colisao = new Acidente();
        Acidente acidente;
        int pontoImpacto;
        int idBoletim;

        public frmAcidentes(int _idBoletim)
        {
            idBoletim = _idBoletim;
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            acidente = new Acidente(cmbTipoAcidente.Text, cmbTipoAcidente.Text, txtMarca.Text, txtModelo.Text, txtPlaca.Text,
                Convert.ToInt32(cmbUf.SelectedValue), txtCidade.Text, txtChassi.Text, txtCor.Text, txtAno.Text, txtPontoImpacto.Text, cmbDanos.Text, idBoletim);

            acidente.ColisaoFrontalDireita = colisao.ColisaoFrontalDireita;
            acidente.ColisaoFrontal = colisao.ColisaoFrontal;
            acidente.ColisaoFrontalEsquerda = colisao.ColisaoFrontalEsquerda;
            acidente.ColisaoLateralDireita = colisao.ColisaoLateralDireita;
            acidente.ColisaoLateralEsquerda = colisao.ColisaoLateralEsquerda;
            acidente.ColisaoLateralTrasDireita = colisao.ColisaoLateralTrasDireita;
            acidente.ColisaoLateralTrasEsquerda = colisao.ColisaoLateralTrasEsquerda;
            acidente.ColisaoTraseira = colisao.ColisaoTraseira;
            acidente.ColisaoTraseiraDireita = colisao.ColisaoTraseiraDireita;
            acidente.ColisaoTraseiraEsquerda = colisao.ColisaoTraseiraEsquerda;

            _acidenteServices = new AcidenteServices(_acidenteRespository);
            MessageBox.Show(_acidenteServices.CadastrarAcidente(acidente));
        }
        
        private void chkFrontalDireita_CheckedChanged(object sender, EventArgs e)
        {

            if (chkFrontalDireita.Checked)
            {
                pontoImpacto += 1;
                colisao.ColisaoFrontalDireita = 1;

            }

            else
            {
                pontoImpacto -= 1;
                colisao.ColisaoFrontalDireita = 0;
            }  
        }

        private void chkLateralDireita_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLateralDireita.Checked)
            {
                pontoImpacto += 1;
                colisao.ColisaoLateralDireita = 1;
            }
            else
            {
                pontoImpacto -= 1;
                colisao.ColisaoLateralDireita = 0;
            }
        }

        private void chkLateralTrasDireita_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLateralTrasDireita.Checked)
            {
                pontoImpacto += 1;
                colisao.ColisaoLateralTrasDireita = 1;
            }
            else
            {
                pontoImpacto -= 1;
                colisao.ColisaoLateralTrasDireita = 0;
            }
        }

        private void chkTraseiraDireita_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTraseiraDireita.Checked)
            {
                pontoImpacto += 1;
                colisao.ColisaoTraseiraDireita = 1;
            }

            else
            {
                pontoImpacto -= 1;
                colisao.ColisaoTraseiraDireita = 0;
            }
        }

        private void chkTraseira_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTraseira.Checked)
            {
                pontoImpacto += 1;
                colisao.ColisaoTraseira = 1;
            }

            else
            {
                pontoImpacto -= 1;
                colisao.ColisaoTraseira = 0;
            }
        }

        private void chkTraseiraEsquerda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTraseiraEsquerda.Checked)
            {
                pontoImpacto += 1;
                colisao.ColisaoTraseiraEsquerda = 1;
            }

            else
            {
                pontoImpacto -= 1;
                colisao.ColisaoTraseiraEsquerda = 0;
            }
        }

        private void chkLateralTrasEsquerda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLateralTrasEsquerda.Checked)
            {
                pontoImpacto += 1;
                colisao.ColisaoLateralTrasEsquerda = 1;
            }

            else
            {
                pontoImpacto -= 1;
                colisao.ColisaoLateralTrasEsquerda = 0;
            }
        }

        private void chkLateralEsquerda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLateralEsquerda.Checked)
            {
                pontoImpacto += 1;
                colisao.ColisaoLateralEsquerda = 1;
            }

            else
            {
                pontoImpacto -= 1;
                colisao.ColisaoLateralEsquerda = 0;
            }
        }

        private void chkFrontalEsquerda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFrontalEsquerda.Checked)
            {
                pontoImpacto += 1;
                colisao.ColisaoFrontalEsquerda = 1;
            }

            else
            {
                pontoImpacto -= 1;
                colisao.ColisaoFrontalEsquerda = 0;
            }
        }

        private void chkFrontal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFrontal.Checked)
            {
                pontoImpacto += 1;
                colisao.ColisaoFrontal = 1;
            }

            else
            {
                pontoImpacto -= 1;
                colisao.ColisaoFrontal = 0;
            }
        }

        private void frmAcidentes_Load(object sender, EventArgs e)
        {
            _acidenteServices = new AcidenteServices(_acidenteRespository);
            cmbUf.DataSource = _acidenteServices.RetornarEstadoUF();
            cmbUf.DisplayMember = "sigla";
            cmbUf.ValueMember = "id";
        }
    }
}
