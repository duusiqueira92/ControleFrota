using BLL;
using DAL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class frmEquipes : Form
    {
        public frmEquipes()
        {
            InitializeComponent();
        }

        DataRowView drv;
        VeiculoAbordado veiculoAbordado;
        Manutencao manutencao;
        Abordado abordado;
        Equipe equipes;
        AbordadoServices abordadoServices;
        BLL.EquipeServices equipeBLL;
        int equipe, plantao, id_producao, id_viatura;
              
        private void CarregarMotorista(int plantao, int equipe)
        {
            if (cmbPlantao.SelectedIndex != -1 && cmbEquipe.SelectedIndex != -1)
            {
                cmbMotorista.Enabled = true;
                cmbEncarregado.Enabled = true;
                equipeBLL = new BLL.EquipeServices();
                cmbMotorista.DataSource = equipeBLL.CarregarMotorista(plantao, equipe);
                cmbMotorista.DisplayMember = "qra";
                cmbMotorista.ValueMember = "id";
                cmbMotorista.SelectedIndex = -1;
            }
        }

        private void CarregarEncarregado(int plantao, int equipe)
        {
            if (cmbPlantao.SelectedIndex != -1 && cmbEquipe.SelectedIndex != -1)
            {
                equipeBLL = new BLL.EquipeServices();
                cmbEncarregado.DataSource = equipeBLL.CarregarEncarregado(plantao, equipe);
                cmbEncarregado.DisplayMember = "qra";
                cmbEncarregado.ValueMember = "id";
                cmbEncarregado.SelectedIndex = -1;
            }
        }

        private void CarregarPlantao()
        {
            equipeBLL = new BLL.EquipeServices();
            cmbPlantao.DataSource = equipeBLL.CarregarPlantao();
            cmbPlantao.DisplayMember = "nome_plantao";
            cmbPlantao.ValueMember = "id";
            cmbPlantao.SelectedIndex = -1;
        }

        private void CarregarEquipe()
        {
            equipeBLL = new BLL.EquipeServices();
            cmbEquipe.DataSource = equipeBLL.CarregarEquipe();
            cmbEquipe.DisplayMember = "nome_equipe";
            cmbEquipe.ValueMember = "id";
            cmbEquipe.SelectedIndex = -1;
        }

        private void CarregarViatura()
        {
            equipeBLL = new BLL.EquipeServices();
            cmbViatura.DataSource = equipeBLL.CarregarViatura();
            cmbViatura.DisplayMember = "prefixo";
            cmbViatura.ValueMember = "id_veiculo";
            cmbViatura.SelectedIndex = -1;
        }

        private void CarregarDataGrid()
        {
            equipeBLL = new BLL.EquipeServices();
            dgvPlantaoViaturas.DataSource = equipeBLL.CarregarDataGrid();
        }

        private void CarregarRelatorios(int equipe)
        {
            abordadoServices = new AbordadoServices();
            //dgvVeiculosAbordados.DataSource = equipeBLL.CarregarVeiculosAbordados(equipe);
            dgvAbordados.DataSource = abordadoServices.CarregarAbordados(equipe);
        }

        private void CarregarManutencao()
        {
            DataTable dt = new DataTable();
            equipeBLL = new BLL.EquipeServices();
            manutencao = new Manutencao();
            dt = equipeBLL.CarregarManutencao(id_viatura);
            if (dt.Rows.Count != 0)
            {
                manutencao.Km_F_Combustivel = dt.Rows[0]["km_f_combustivel"].ToString();
                manutencao.Km_F_Oleo = dt.Rows[0]["km_f_oleo"].ToString();
                manutencao.Km_Oleo = dt.Rows[0]["km_oleo"].ToString();
                manutencao.Km_Pdd = dt.Rows[0]["km_pdd"].ToString();
                manutencao.Km_Pde = dt.Rows[0]["km_pde"].ToString();
                manutencao.Km_Pte = dt.Rows[0]["km_pte"].ToString();
                manutencao.Km_Ptd = dt.Rows[0]["km_ptd"].ToString();

                if (cmbViatura.SelectedIndex != -1)
                {
                    if (Convert.ToInt32(txtKmTermino.Text) > Convert.ToInt32(manutencao.Km_F_Combustivel))
                    {
                        lblFCombustivel.Text = "Trocar";
                        lblFCombustivel.ForeColor = Color.Red;
                    }

                    else
                    {
                        lblFCombustivel.Text = "OK";
                        lblFCombustivel.ForeColor = Color.Lime;
                    }

                    if (Convert.ToInt32(txtKmTermino.Text) > Convert.ToInt32(manutencao.Km_Oleo))
                    {
                        lblOleo.Text = "Trocar";
                        lblOleo.ForeColor = Color.Red;
                    }

                    else
                    {
                        lblOleo.Text = "OK";
                        lblOleo.ForeColor = Color.Lime;
                    }

                    if (Convert.ToInt32(txtKmTermino.Text) > Convert.ToInt32(manutencao.Km_F_Oleo))
                    {
                        lblFOleo.Text = "Trocar";
                        lblFOleo.ForeColor = Color.Red;
                    }

                    else
                    {
                        lblFOleo.Text = "OK";
                        lblFOleo.ForeColor = Color.Lime;
                    }

                    if (Convert.ToInt32(txtKmTermino.Text) > Convert.ToInt32(manutencao.Km_Pdd))
                    {
                        lblPDD.Text = "Trocar";
                        lblPDD.ForeColor = Color.Red;
                    }

                    else
                    {
                        lblPDD.Text = "OK";
                        lblPDD.ForeColor = Color.Lime;
                    }

                    if (Convert.ToInt32(txtKmTermino.Text) > Convert.ToInt32(manutencao.Km_Pde))
                    {
                        lblPDE.Text = "Trocar";
                        lblPDE.ForeColor = Color.Red;
                    }

                    else
                    {
                        lblPDE.Text = "OK";
                        lblPDE.ForeColor = Color.Lime;
                    }
                    if (Convert.ToInt32(txtKmTermino.Text) > Convert.ToInt32(manutencao.Km_Pte))
                    {
                        lblPTE.Text = "Trocar";
                        lblPTE.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblPTE.Text = "OK";
                        lblPTE.ForeColor = Color.Lime;
                    }
                    if (Convert.ToInt32(txtKmTermino.Text) > Convert.ToInt32(manutencao.Km_Ptd))
                    {
                        lblPTD.Text = "Trocar";
                        lblPTD.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblPTD.Text = "OK";
                        lblPTD.ForeColor = Color.Lime;
                    }
                }
            }

            else
             {
                manutencao = null;
             }
        }

        private Boolean validaDados()
        {
            if (Convert.ToDouble(txtLitros.Text) < 0.1)
            {
                MessageBox.Show("Valor inválido para o campo LITROS", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLitros.Focus();
                return false;
            }
            if (cmbPlantao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um PLANTÃO", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPlantao.Focus();
                return false;
            }

            if (cmbEquipe.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma EQUIPE", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbEquipe.Focus();
                return false;
            }

            if (cmbViatura.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma VIATURA", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbViatura.Focus();
                return false;
            }

            if (cmbMotorista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um MOTORISTA", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMotorista.Focus();
                return false;
            }

            if (cmbEncarregado.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um ENCARREGADO", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbEncarregado.Focus();
                return false;
            }

            if (Convert.ToInt32(txtKmTermino.Text) < Convert.ToInt32(txtKmInicio.Text))
            {
                MessageBox.Show("Verifique o KM final", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKmTermino.Focus();
                return false;
            }
            

            if (txtLitros.Text == String.Empty)
            {
                MessageBox.Show("Verifique o campo LITROS", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLitros.Focus();
                return false;
            }
            return true;
        }

        private void LimparAbordados()
        {
            txtArtigo.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtRg.Text = String.Empty;
            cmbPassagens.SelectedIndex = -1;
        }

        private void LimparVeiculosAbordados()
        {
            txtCondutor.Text = String.Empty;
            txtEnderecoVeiculoAbordado.Text = String.Empty;
            txtVeiculoAbordadoMarca.Text = String.Empty;
            txtVeiculoAbordadoModelo.Text = String.Empty;
            txtVeiculoAbordadoPlaca.Text = String.Empty;
        }

        private void LimparEquipe()
        {
            LimparVeiculosAbordados();
            LimparAbordados();
            txtKmInicio.Text = String.Empty;
            txtKmTermino.Text = String.Empty;
            txtLitros.Text = String.Empty;
            txtObs.Text = String.Empty;
            dtpDataPlantao.Value = DateTime.Now;
            cmbAbastecido.SelectedIndex = -1;
            cmbEncarregado.SelectedIndex = -1;
            cmbMotorista.SelectedIndex = -1;
            cmbPlantao.SelectedIndex = -1;
            cmbEquipe.SelectedIndex = -1;
            cmbViatura.SelectedIndex = -1;
            txtLitros.Enabled = false;
            equipe = 0;
            plantao = 0;
            id_viatura = 0;
        }

        private void frmEquipes_Load(object sender, EventArgs e)
        {
            dtpDataPlantao.Value = DateTime.Now;
            CarregarPlantao();
            CarregarEquipe();
            CarregarViatura();
            CarregarDataGrid();
        }

        private void cmbViatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbViatura.SelectedIndex != -1)
            {
                drv = ((DataRowView)cmbViatura.SelectedItem);
                id_viatura = Convert.ToInt16(drv["id_veiculo"]);
                txtKmInicio.Text = drv["km"].ToString();
            }
            else
            {
                txtKmInicio.Text = "";
            }
        }

        private void txtKmTermino_Leave(object sender, EventArgs e)
        {
            if (txtKmTermino.Text == String.Empty)
            {
                MessageBox.Show("Verifique o campo KM TERMINO", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKmTermino.Focus();
            }
            CarregarManutencao();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                equipes = new Equipe(plantao, equipe, Convert.ToInt16(cmbViatura.SelectedValue), Convert.ToInt32(txtKmInicio.Text), Convert.ToInt32(txtKmTermino.Text), cmbAbastecido.Text,
                Convert.ToDouble(txtLitros.Text.Replace(".", ",")), txtObs.Text, dtpDataPlantao.Text,
                Convert.ToInt16(cmbMotorista.SelectedValue), Convert.ToInt16(cmbEncarregado.SelectedValue));

                MessageBox.Show(equipeBLL.CadastrarEquipe(equipes));
                CarregarDataGrid();
                LimparEquipe();
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //btnVeiculoAbordado
        private void button2_Click(object sender, EventArgs e)
        {
            veiculoAbordado = new VeiculoAbordado(txtCondutor.Text, txtVeiculoAbordadoMarca.Text,
                txtVeiculoAbordadoModelo.Text, txtVeiculoAbordadoPlaca.Text, txtEndereco.Text, id_producao);
            equipeBLL = new BLL.EquipeServices();
            MessageBox.Show(equipeBLL.CadastrarVeiculoAbordado(veiculoAbordado));
            LimparVeiculosAbordados();
        }

        private void btnInserirAbordado_Click(object sender, EventArgs e)
        {
            abordado = new Abordado(txtNome.Text, txtRg.Text, txtEndereco.Text, cmbPassagens.Text, txtArtigo.Text, id_producao);
            abordadoServices = new AbordadoServices();
            MessageBox.Show(abordadoServices.CadastrarAbordado(abordado));
            LimparAbordados();
        }
      
        private void dgvPlantaoViaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMotorista.Text = dgvPlantaoViaturas.Rows[e.RowIndex].Cells["Motorista"].Value.ToString();
            lblEncarregado.Text = dgvPlantaoViaturas.Rows[e.RowIndex].Cells["Encarregado"].Value.ToString();
            lblVtr.Text = dgvPlantaoViaturas.Rows[e.RowIndex].Cells["prefixo"].Value.ToString();
            id_producao = Convert.ToInt16(dgvPlantaoViaturas.Rows[e.RowIndex].Cells["id"].Value);
            CarregarRelatorios(id_producao);

            if (id_producao != 0)
                grbRelatorios.Enabled = true;

            else
                grbRelatorios.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparEquipe();
        }

        private void cmbPlantao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlantao.SelectedIndex != -1)
            {
                drv = ((DataRowView)cmbPlantao.SelectedItem);
                plantao = Convert.ToInt16(drv["id"]);
                CarregarMotorista(plantao, equipe);
                CarregarEncarregado(plantao, equipe);
            }
        }

        private void cmbEquipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquipe.SelectedIndex != -1)
            {
                DataRowView drv = ((DataRowView)cmbEquipe.SelectedItem);
                equipe = Convert.ToInt16(drv["id"]);
                CarregarMotorista(plantao, equipe);
                CarregarEncarregado(plantao, equipe);
            }
        }

        private void cmbAbastecido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAbastecido.Text == "NÃO")
            {
                txtLitros.Text = "0";
                txtLitros.Enabled = false;
            }

            else
                txtLitros.Enabled = true;
        }
    }
}
