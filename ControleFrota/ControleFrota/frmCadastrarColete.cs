using BLL;
using BLL.Interfaces;
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
    public partial class frmCadastrarColete : Form
    {
        int agente;
        string nome;
        Colete colete;
        IColeteServices _coleteServices;

        public frmCadastrarColete(int _agente, string _nome)
        {
            agente = _agente;
            nome = _nome;
            InitializeComponent();
        }

        private void CadastrarColete()
        {
            colete = new Colete();
            colete.DataFabricacao = dtpDataFabricacao.Text;
            colete.Proprietario = txtProprietario.Text.Trim();
            colete.NumLote = txtNumLote.Text.Trim();
            colete.NumSerie = txtNumSerie.Text.Trim();
            colete.NumCA = txtNumCA.Text.Trim();
            colete.Nivel = txtNivel.Text.Trim();
            colete.Tamanho = cmbTamanho.Text;
            colete.Agente = agente;
            _coleteServices = new ColeteServices();
            MessageBox.Show(_coleteServices.CadastrarColete(colete), "Cadastrado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpar()
        {
            txtNivel.Text = String.Empty;
            txtNumCA.Text = String.Empty;
            txtNumLote.Text = String.Empty;
            txtNumSerie.Text = String.Empty;
            txtProprietario.Text = String.Empty;
            cmbTamanho.SelectedIndex = -1;
            dtpDataFabricacao.Value = DateTime.Now;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarColete();
        }

        private void frmCadastrarColete_Load(object sender, EventArgs e)
        {
            lblAgente.Text = nome;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
