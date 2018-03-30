using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class frmGerenciarPlantao : Form
    {
        public frmGerenciarPlantao()
        {
            InitializeComponent();
        }
        BLL.GerenciadorPlantaoServices gerenciadorPlantaoBLL;
        Funcionario funcionario;
        int id;

        private void HabilitarComboBox()
        {
            funcionario = new Funcionario();
            if (funcionario.Id == 0)
            {
                cmbEquipe.Enabled = false;
                cmbPlantao.Enabled = false;
                cmbPosicao.Enabled = false;
            }
            else
            {
                cmbEquipe.Enabled = true;
                cmbPlantao.Enabled = true;
                cmbPosicao.Enabled = true;
            }
        }

        private void CarregarDados()
        {
            gerenciadorPlantaoBLL = new BLL.GerenciadorPlantaoServices();
            dgvAgentes.DataSource = gerenciadorPlantaoBLL.CarregarAgentes();

            cmbPlantao.DataSource = gerenciadorPlantaoBLL.CarregarPlantao();
            cmbPlantao.DisplayMember = "nome_plantao";
            cmbPlantao.ValueMember = "id";
            cmbPlantao.SelectedIndex = -1;

            cmbEquipe.DataSource = gerenciadorPlantaoBLL.CarregarEquipes();
            cmbEquipe.DisplayMember = "nome_equipe";
            cmbEquipe.ValueMember = "id";
            cmbEquipe.SelectedIndex = -1;

            cmbPosicao.DataSource = gerenciadorPlantaoBLL.CarregarPosicao();
            cmbPosicao.DisplayMember = "posicao";
            cmbPosicao.ValueMember = "id";
            cmbPosicao.SelectedIndex = -1;
        }

        private void Salvar()
        {
            gerenciadorPlantaoBLL = new BLL.GerenciadorPlantaoServices();
            MessageBox.Show(gerenciadorPlantaoBLL.AlterarPlantao(id, Convert.ToInt16(cmbPlantao.SelectedValue), 
                Convert.ToInt16(cmbEquipe.SelectedValue), Convert.ToInt16(cmbPosicao.SelectedValue)));
        }

        private void frmGerenciarPlantao_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dgvAgentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt16(dgvAgentes.Rows[e.RowIndex].Cells["id_agente"].Value);
            cmbPosicao.SelectedValue = Convert.ToInt16(dgvAgentes.Rows[e.RowIndex].Cells["PSID"].Value);
            cmbEquipe.SelectedValue = Convert.ToInt16(dgvAgentes.Rows[e.RowIndex].Cells["EID"].Value);
            cmbPlantao.SelectedValue = Convert.ToInt16(dgvAgentes.Rows[e.RowIndex].Cells["PID"].Value);
            lblAgente.Text = dgvAgentes.Rows[e.RowIndex].Cells["QRA"].Value.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            gerenciadorPlantaoBLL = new BLL.GerenciadorPlantaoServices();
            dgvAgentes.DataSource = gerenciadorPlantaoBLL.CarregarAgentes();
        }
    }
}
