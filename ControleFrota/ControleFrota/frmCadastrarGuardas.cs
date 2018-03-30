using BLL;
using DAL;
using DAL.Interfaces;
using System;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class frmCadastrarGuardas : Form
    {
        Graduacao grad;
        GraduacaoServices graduacaoServices;
        FuncionarioServices funcionarioServices;
        Funcionario funcionario;
        int id;
        ICpfServices _cpfServices;

        public frmCadastrarGuardas()
        {
            InitializeComponent();
        }

        private void btnArma_Click_1(object sender, EventArgs e)
        {
            frmCadastrarArma frmCadArma = new frmCadastrarArma(funcionario.Id, funcionario.Nome, funcionario.Cpf, funcionario.Rg);
            frmCadArma.ShowDialog();
        }

        private void btnColete_Click(object sender, EventArgs e)
        {
            frmCadastrarColete frmCadColete = new frmCadastrarColete(funcionario.Id, funcionario.Nome);
            frmCadColete.ShowDialog();
        }
        
        //EVENTO LOAD
        private void frmCadastrarGuardas_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            CarregarDataGrid();
        }
        //carrega todos os cmbBox do form
        private void CarregarComboBox()
        {
            grad = new Graduacao();
            graduacaoServices = new GraduacaoServices();
            funcionarioServices = new FuncionarioServices();

            cmbGraduacao.DataSource = graduacaoServices.CarregarGraduacao(grad);
            cmbGraduacao.DisplayMember = "graduacao";
            cmbGraduacao.ValueMember = "id";
            cmbGraduacao.SelectedIndex = -1;

            cmbOeUF.DataSource = funcionarioServices.CarregarEstado();
            cmbOeUF.DisplayMember = "sigla";
            cmbOeUF.ValueMember = "id";
            cmbOeUF.SelectedIndex = -1;

            cmbUfNaturalidade.DataSource = funcionarioServices.CarregarEstado();
            cmbUfNaturalidade.DisplayMember = "sigla";
            cmbUfNaturalidade.ValueMember = "id";
            cmbUfNaturalidade.SelectedIndex = -1;

            cmbUf.DataSource = funcionarioServices.CarregarEstado();
            cmbUf.DisplayMember = "sigla";
            cmbUf.ValueMember = "id";
            cmbUf.SelectedIndex = -1;

            cmbUfProf.DataSource = funcionarioServices.CarregarEstado();
            cmbUfProf.DisplayMember = "sigla";
            cmbUfProf.ValueMember = "id";
            cmbUfProf.SelectedIndex = -1;

            cmbCategoria.DataSource = funcionarioServices.CarregarCategoria();
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id";
            cmbCategoria.SelectedIndex = -1;

            cmbOrgEmissor.DataSource = funcionarioServices.CarregarOrgEmissor();
            cmbOrgEmissor.DisplayMember = "sigla";
            cmbOrgEmissor.ValueMember = "id";
            cmbOrgEmissor.SelectedIndex = -1;
        }
        //btnSalvar
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            funcionario = new Funcionario(txtNome.Text, txtEndereco.Text, txtNumero.Text, txtBairro.Text,
                txtCidade.Text, Convert.ToInt16(cmbUf.SelectedValue), txtCep.Text, txtCelular.Text,
                txtNumCnh.Text, txtRegCnh.Text, Convert.ToInt16(cmbCategoria.SelectedValue), dtpValidadeCnh.Text,
                txtPasep.Text, txtRg.Text, Convert.ToInt16(cmbOrgEmissor.SelectedValue), Convert.ToInt16(cmbOeUF.SelectedValue),
                dtpRgExpedido.Text, txtCpf.Text, dtpNascimento.Text, cmbEstadoCivil.Text, cmbFilhos.Text, cmbEscolaridade.Text,
                txtFormacaoMedio.Text, txtInstituicao.Text, cmbTipoSanguineo.Text, cmbRestricao.Text, txtNomePai.Text, txtNomeMae.Text,
                txtRf.Text, dtpDataAdmissao.Text, txtQra.Text, Convert.ToInt16(cmbGraduacao.SelectedValue), _cpfServices);
            funcionario.Complemento = txtComplemento.Text;
            funcionario.Telefone = txtTelefone.Text;//cripto
            funcionario.Zona = txtZona.Text;//cripto
            funcionario.Titulo_Eleitor = txtTitEleitor.Text;//cripto
            funcionario.Cidade_Titulo = txtCidadeTitulo.Text;
            funcionario.Estado_Titulo = Convert.ToInt32(cmbUfProf.SelectedValue);
            funcionario.Sessao = txtSessao.Text;
            funcionario.Emissao_Titulo = dtpEmissaoTitulo.Text;
            funcionario.Conclusao_Superior = txtConclusaoSuperior.Text;
            funcionario.Formacao = cmbFormacao.Text;
            funcionario.Observacao = txtObservacao.Text;
            funcionario.Naturalidade = txtNaturalidade.Text;
            funcionario.Uf_Naturalidade = Convert.ToInt32(cmbUfNaturalidade.SelectedValue);
            funcionario.Id = id;

            if (id == 0)
            {
                funcionarioServices = new FuncionarioServices();
                MessageBox.Show(funcionarioServices.AdicionarFuncionario(funcionario));
            }
            else
            {
                funcionarioServices = new FuncionarioServices();
                MessageBox.Show(funcionarioServices.AlterarFuncionario(funcionario));
            }
            funcionario.Id = 0;
            CarregarDataGrid();
            AtivarBotoes();
            Limpar();
        }

        private void CarregarDataGrid()
        {
            dgvGuardas.DataSource = funcionarioServices.CarregarFuncionario();
            dgvGuardas.Refresh();
            dgvEquipamentos.Refresh();
        }
        //selecionar plantao
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAgentePlantao selecionarPlantao = new frmAgentePlantao(funcionario.Id);
            selecionarPlantao.ShowDialog();
            funcionario.Id = 0;
            toolStripButton1.Enabled = false;
            CarregarDataGrid();
        }

        private void AtivarBotoes()
        {
            if (funcionario.Id == 0)
            {
                btnArma.Enabled = false;
                btnColete.Enabled = false;
                toolStripButton1.Enabled = false;
                btnAlterar.Enabled = false;
            }

            else
            {
                btnArma.Enabled = true;
                btnColete.Enabled = true;
                toolStripButton1.Enabled = true;
                btnAlterar.Enabled = true;
            }
        }

        private void dgvGuardas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                funcionario = new Funcionario(_cpfServices);
                funcionario.Id = Convert.ToInt16(dgvGuardas.Rows[e.RowIndex].Cells["id_agente"].Value);
                funcionario.Nome = dgvGuardas.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                funcionario.Rua = dgvGuardas.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
                funcionario.Bairro = dgvGuardas.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
                funcionario.Cidade = dgvGuardas.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
                funcionario.Numero = dgvGuardas.Rows[e.RowIndex].Cells["numero"].Value.ToString();
                funcionario.Complemento = dgvGuardas.Rows[e.RowIndex].Cells["complemento"].Value.ToString();
                funcionario.Estado = Convert.ToInt16(dgvGuardas.Rows[e.RowIndex].Cells["estado"].Value);
                funcionario.Cep = dgvGuardas.Rows[e.RowIndex].Cells["cep"].Value.ToString();
                funcionario.Telefone = dgvGuardas.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
                funcionario.Celular = dgvGuardas.Rows[e.RowIndex].Cells["celular"].Value.ToString();
                funcionario.Cnh = dgvGuardas.Rows[e.RowIndex].Cells["num_cnh"].Value.ToString();
                funcionario.RegCnh = dgvGuardas.Rows[e.RowIndex].Cells["reg_cnh"].Value.ToString();
                funcionario.Categoria = Convert.ToInt16(dgvGuardas.Rows[e.RowIndex].Cells["categoria"].Value);
                funcionario.Validade_cnh = dgvGuardas.Rows[e.RowIndex].Cells["validade"].Value.ToString();/**/
                funcionario.Zona = dgvGuardas.Rows[e.RowIndex].Cells["zona"].Value.ToString();
                funcionario.Titulo_Eleitor = dgvGuardas.Rows[e.RowIndex].Cells["tit_eleitor"].Value.ToString();
                funcionario.Cidade_Titulo = dgvGuardas.Rows[e.RowIndex].Cells["cidade_tit"].Value.ToString();
                funcionario.Estado_Titulo = Convert.ToInt16(dgvGuardas.Rows[e.RowIndex].Cells["estado_titulo"].Value);
                funcionario.Sessao = dgvGuardas.Rows[e.RowIndex].Cells["sessao"].Value.ToString();
                funcionario.Emissao_Titulo = dgvGuardas.Rows[e.RowIndex].Cells["emissao_titulo"].Value.ToString();
                funcionario.Pis = dgvGuardas.Rows[e.RowIndex].Cells["pis"].Value.ToString();
                funcionario.Rg = dgvGuardas.Rows[e.RowIndex].Cells["rg"].Value.ToString();
                funcionario.OrgaoEmissor = Convert.ToInt16(dgvGuardas.Rows[e.RowIndex].Cells["emissor"].Value);
                funcionario.Rg_Uf = Convert.ToInt16(dgvGuardas.Rows[e.RowIndex].Cells["estado_rg"].Value);
                funcionario.Emissao_Rg = dgvGuardas.Rows[e.RowIndex].Cells["emissao_rg"].Value.ToString() ;
                funcionario.DataNascimento = dgvGuardas.Rows[e.RowIndex].Cells["data_nascimento"].Value.ToString();
                funcionario.Cpf = dgvGuardas.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                funcionario.Estado_Civil = dgvGuardas.Rows[e.RowIndex].Cells["estado_civil"].Value.ToString();
                funcionario.Filhos = dgvGuardas.Rows[e.RowIndex].Cells["filhos"].Value.ToString();
                funcionario.Escolaridade = dgvGuardas.Rows[e.RowIndex].Cells["escolaridade"].Value.ToString();
                funcionario.Conclusao_Escolar = dgvGuardas.Rows[e.RowIndex].Cells["ano_conclusao"].Value.ToString();
                funcionario.Instituicao = dgvGuardas.Rows[e.RowIndex].Cells["instituicao"].Value.ToString();
                funcionario.Formacao = dgvGuardas.Rows[e.RowIndex].Cells["formacao"].Value.ToString();
                funcionario.Conclusao_Superior = dgvGuardas.Rows[e.RowIndex].Cells["conclusao_formacao"].Value.ToString();
                funcionario.Tipo_Sanguineo = dgvGuardas.Rows[e.RowIndex].Cells["tipo_sanguineo"].Value.ToString();
                funcionario.Restricao = dgvGuardas.Rows[e.RowIndex].Cells["restricao"].Value.ToString();
                funcionario.Observacao = dgvGuardas.Rows[e.RowIndex].Cells["obs_restricao"].Value.ToString();
                funcionario.Nome_Pai = dgvGuardas.Rows[e.RowIndex].Cells["pai"].Value.ToString();
                funcionario.Nome_Mae = dgvGuardas.Rows[e.RowIndex].Cells["mae"].Value.ToString();
                funcionario.Naturalidade = dgvGuardas.Rows[e.RowIndex].Cells["naturalidade"].Value.ToString();
                funcionario.Uf_Naturalidade = Convert.ToInt16(dgvGuardas.Rows[e.RowIndex].Cells["naturalidade_estado"].Value);
                funcionario.Rf = dgvGuardas.Rows[e.RowIndex].Cells["reg_funcional"].Value.ToString();
                funcionario.DataContratacao = dgvGuardas.Rows[e.RowIndex].Cells["data_admissao"].Value.ToString();
                funcionario.Qra = dgvGuardas.Rows[e.RowIndex].Cells["qra"].Value.ToString();
                funcionario.Graduacao = Convert.ToInt16(dgvGuardas.Rows[e.RowIndex].Cells["graduacao"].Value);

                    if (funcionario.Id != 0)
                    {
                        AtivarBotoes();
                        dgvEquipamentos.DataSource = funcionarioServices.CarregarEquipamentos(funcionario.Id);
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o agente! " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar(); 
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            id = funcionario.Id;
            txtNome.Text = funcionario.Nome;
            txtEndereco.Text = funcionario.Rua;
            txtBairro.Text = funcionario.Bairro;
            txtCidade.Text = funcionario.Cidade;
            txtNumero.Text = funcionario.Numero;
            txtComplemento.Text = funcionario.Complemento;
            txtNumero.Text = funcionario.Numero;
            cmbUf.SelectedValue = funcionario.Estado;
            txtCep.Text = funcionario.Cep;
            txtTelefone.Text = funcionario.Telefone;
            txtCelular.Text = funcionario.Celular;
            txtNumCnh.Text = funcionario.Cnh;
            txtRegCnh.Text = funcionario.RegCnh;
            cmbCategoria.SelectedValue = funcionario.Categoria;
            dtpValidadeCnh.Value = Convert.ToDateTime(funcionario.Validade_cnh);
            txtZona.Text = funcionario.Zona;
            txtSessao.Text = funcionario.Sessao;
            txtTitEleitor.Text = funcionario.Titulo_Eleitor;
            txtCidadeTitulo.Text = funcionario.Cidade_Titulo;
            cmbUfProf.SelectedValue = funcionario.Estado_Titulo;
            dtpEmissaoTitulo.Value = Convert.ToDateTime(funcionario.Emissao_Titulo);
            txtPasep.Text = funcionario.Pis;
            txtRg.Text = funcionario.Rg;
            cmbOrgEmissor.SelectedValue = funcionario.OrgaoEmissor;
            cmbEstadoCivil.Text = funcionario.Estado_Civil;
            cmbFilhos.Text = funcionario.Filhos;
            cmbOeUF.SelectedValue = funcionario.Rg_Uf;
            dtpRgExpedido.Value = Convert.ToDateTime(funcionario.Emissao_Rg);
            txtCpf.Text = funcionario.Cpf;
            dtpNascimento.Value = Convert.ToDateTime(funcionario.DataNascimento);
            cmbEscolaridade.Text = funcionario.Escolaridade;
            txtFormacaoMedio.Text = funcionario.Conclusao_Escolar;
            txtInstituicao.Text = funcionario.Instituicao;
            cmbFormacao.Text = funcionario.Formacao;
            txtConclusaoSuperior.Text = funcionario.Conclusao_Superior;
            cmbTipoSanguineo.Text = funcionario.Tipo_Sanguineo;
            cmbRestricao.Text = funcionario.Restricao;
            txtObservacao.Text = funcionario.Observacao;
            txtNomePai.Text = funcionario.Nome_Pai;
            txtNomeMae.Text = funcionario.Nome_Mae;
            txtNaturalidade.Text = funcionario.Naturalidade;
            cmbUfNaturalidade.SelectedValue = funcionario.Uf_Naturalidade;
            txtRf.Text = funcionario.Rf;
            dtpDataAdmissao.Value = Convert.ToDateTime(funcionario.DataContratacao);
            txtQra.Text = funcionario.Qra;
            cmbGraduacao.SelectedValue = funcionario.Graduacao;
        }

        private void Limpar()
        {
            funcionario.Id = 0;
            txtNome.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtCep.Text = String.Empty;
            txtComplemento.Text = String.Empty;
            cmbUf.SelectedValue = -1;
            txtTelefone.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtNumCnh.Text = String.Empty;
            txtRegCnh.Text = String.Empty;
            cmbCategoria.SelectedValue = -1;
            dtpValidadeCnh.ResetText();
            txtZona.Text = String.Empty;
            txtTitEleitor.Text = String.Empty;
            txtSessao.Text = String.Empty;
            txtCidadeTitulo.Text = String.Empty;
            cmbUfProf.SelectedValue = -1;
            dtpEmissaoTitulo.ResetText();
            txtPasep.Text = String.Empty;
            txtRg.Text = String.Empty;
            cmbOeUF.SelectedValue = -1;
            cmbOrgEmissor.SelectedValue = -1;
            dtpRgExpedido.ResetText();
            txtCpf.Text = String.Empty;
            dtpNascimento.ResetText();
            cmbEstadoCivil.SelectedIndex = -1;
            cmbEscolaridade.SelectedIndex = -1;
            cmbFilhos.SelectedIndex = -1;
            txtConclusaoSuperior.Text = String.Empty;
            txtFormacaoMedio.Text = String.Empty;
            txtInstituicao.Text = String.Empty;
            cmbFormacao.SelectedIndex = -1;
            cmbTipoSanguineo.SelectedIndex = -1;
            cmbRestricao.SelectedIndex = -1;
            txtObservacao.Text = String.Empty;
            txtNomePai.Text = String.Empty;
            txtNomeMae.Text = String.Empty;
            txtNaturalidade.Text = String.Empty;
            txtQra.Text = String.Empty;
            cmbGraduacao.SelectedIndex = -1;
            cmbUfNaturalidade.SelectedIndex = -1;
            txtRf.Text = String.Empty;
            dtpDataAdmissao.ResetText();
            AtivarBotoes();
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            _cpfServices = new CpfServices();
            if (!_cpfServices.Validacao(txtCpf.Text.Trim()))
            {
                MessageBox.Show("CPF Inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
            }
        }

        private void btnCadastrarGraduacao_Click(object sender, EventArgs e)
        {
            frmNovaGraduacao novaGraduacao = new frmNovaGraduacao();
            novaGraduacao.ShowDialog();
        }
    }
}
