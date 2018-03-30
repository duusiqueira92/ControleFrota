using BLL;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class frmViaturas : Form
    {
        IVeiculoServices _viaturaServices;
        Veiculo veiculo;
        IManutencaoServices _manutencaoServices;
        Manutencao manutencao;
        IEmplacamentoServices _emplacamentoServices; //??

        public frmViaturas()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, System.EventArgs e)
        {
            _viaturaServices = new BLL.VeiculoServices();
            veiculo = new Veiculo(_emplacamentoServices);
            try
            {
                veiculo.Prefixo = txtPrefixo.Text;
                veiculo.Modelo = txtModelo.Text;    
                veiculo.Km = Convert.ToInt32(txtKm.Text);
                veiculo.Marca = txtMarca.Text;
                veiculo.AnoFabricacao = txtAnoFab.Text;
                veiculo.AnoModelo = txtAnoMod.Text;
                veiculo.Placa = txtPlaca.Text; //cripto
                veiculo.Municipio = txtMunicipio.Text;
                veiculo.UF = Convert.ToInt16(cmbUf.SelectedValue);
                veiculo.Combustivel = Convert.ToInt16(cmbCombustivel.SelectedValue);
                veiculo.Renavam = txtRenavam.Text; //cripto
                veiculo.Dpvat = txtDpvat.Text;
                veiculo.Chassi = txtChassi.Text; //cripto
                veiculo.Licenciamento = txtLicenciamento.Text;
                veiculo.Observacao = txtObservacao.Text;

                MessageBox.Show(_viaturaServices.CadastrarVeiculo(veiculo), "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void CarregarComboBox()
        {
            _viaturaServices = new VeiculoServices();
            cmbUf.DataSource = _viaturaServices.CarregarEstado();
            cmbUf.DisplayMember = "sigla";
            cmbUf.ValueMember = "id";
            cmbUf.SelectedValue = -1;

            cmbCombustivel.DataSource = _viaturaServices.CarregarCombustivel();
            cmbCombustivel.DisplayMember = "nome";
            cmbCombustivel.ValueMember = "id";
            cmbCombustivel.SelectedValue = -1;
        }

        private void frmViaturas_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            CarregarDataGrid();
        }

        public void CarregarDataGrid()
        {
            _viaturaServices = new VeiculoServices();
            dgvViaturas.DataSource = _viaturaServices.CarregarVeiculos();
        }

        private void dgvViaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                veiculo = new Veiculo(_emplacamentoServices);
                veiculo.Id_veiculo = Convert.ToInt16(dgvViaturas.Rows[e.RowIndex].Cells["id_veiculo"].Value);
                if (veiculo.Id_veiculo !=0)
                {
                    _manutencaoServices = new ManutencaoServices();
                    groupBox2.Enabled = true;
                    dgvManutencao.DataSource = _manutencaoServices.CarregarManutencao(veiculo.Id_veiculo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO! " + ex.Message);
            }
        }

        private void Limpar()
        {
            txtPlaca.Text = String.Empty;
            txtPrefixo.Text = String.Empty;
            txtMarca.Text = String.Empty;
            txtModelo.Text = String.Empty;
            txtMunicipio.Text = String.Empty;
            txtLicenciamento.Text = String.Empty;
            txtKm.Text = String.Empty;
            txtDpvat.Text = String.Empty;
            txtChassi.Text = String.Empty;
            txtAnoMod.Text = String.Empty;
            txtAnoFab.Text = String.Empty;
            txtRenavam.Text = String.Empty;
            txtObservacao.Text = String.Empty;
            cmbCombustivel.SelectedValue = -1;
            cmbUf.SelectedValue = -1;
        }

        private void LimparManutencao()
        {
            txtMotor.Text = String.Empty;
            txtEquipamentos.Text = String.Empty;
            txtFiltroCombustivel.Text = String.Empty;
            txtFiltroOleo.Text = String.Empty;
            txtLampada.Text = String.Empty;
            txtLataria.Text = String.Empty;
            txtPDD.Text = String.Empty;
            txtPDE.Text = String.Empty;
            txtPTD.Text = String.Empty;
            txtPTE.Text = String.Empty;
            txtTrocaOleo.Text = String.Empty;
            cmbVtrParada.SelectedItem = -1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparManutencao_Click_1(object sender, EventArgs e)
        {
            LimparManutencao();
        }

        private void btnLimparCadastro_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnFinalizarManutencao_Click_1(object sender, EventArgs e)
        {
            if (veiculo.Id_veiculo != 0)
            {
                manutencao = new Manutencao(veiculo.Id_veiculo, dtpManutencao.Value);
                manutencao.Km_Oleo = txtTrocaOleo.Text;
                manutencao.Km_F_Oleo = txtFiltroOleo.Text;
                manutencao.Km_F_Combustivel = txtFiltroCombustivel.Text;
                manutencao.Km_Pte = txtPTE.Text;
                manutencao.Km_Ptd = txtPTD.Text;
                manutencao.Km_Pde = txtPDE.Text;
                manutencao.Km_Pdd = txtPDD.Text;
                manutencao.Lampadas = txtLampada.Text;
                manutencao.Lataria = txtLataria.Text;
                manutencao.Equipamento = txtEquipamentos.Text;
                manutencao.Motor = txtMotor.Text;
                manutencao.Parada = cmbVtrParada.Text;
                manutencao.Data_Manutencao = dtpManutencao.Value;
                _manutencaoServices = new ManutencaoServices();
                MessageBox.Show(_manutencaoServices.CadastrarManutencao(manutencao));
            }
        }
    }
}
