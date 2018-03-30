using BLL;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class frmCadastrarBoletim : Form
    {
        public frmCadastrarBoletim()
        {
            InitializeComponent();
        }

        List<Partes> addParte = new List<Partes>();
        DataRowView drv;
        Partes parte;
        DataTable dt;
        IBoletimOcorrenciaServices _boletimOcorrenciaServices;
        BoletimOcorrencia boletimOcorrencia;
        Acidente acidente = new Acidente();
        ICpfServices _cpfServices;
        int i, plantao, equipe, idBoletim;

        private void frmInformarEquipes_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            dtpValidadeCnh.Value = DateTime.Now;
            dtpSegHoraTermino.Text = DateTime.Now.ToShortTimeString();
            dtpSegHoraInicio.Text = DateTime.Now.ToShortTimeString();
            dtpHoraTermino.Text = DateTime.Now.ToShortTimeString();
            dtpHoraInicio.Text = DateTime.Now.ToShortTimeString();
            dtpDataOcorrencia.Value = DateTime.Now;
            dtpDataNascimento.Value = DateTime.Now;
            dtpDataExpedicaoRg.Value = DateTime.Now;
        }

        private void btnNovaParte_Click(object sender, EventArgs e) 
        {
            parte = new Partes(txtNome.Text, txtNomePai.Text, txtNomeMae.Text, txtTelefone.Text, txtEndereco.Text, txtBairro.Text,
                txtCidade.Text, txtNumero.Text, Convert.ToInt32(cmbEstado.SelectedValue), txtRg.Text, dtpDataNascimento.Text, Convert.ToInt32(cmbOrgaoEmissor.SelectedValue),
                Convert.ToInt32(cmbOrgaoEmissorUf.SelectedValue), cmbTipoParte.Text, cmbConduzido.Text, txtNaturalidade.Text, txtNacionalidade.Text, idBoletim);
            parte.Emissao_Rg = dtpDataExpedicaoRg.Text;
            parte.Cnh = txtCnh.Text;
            parte.RegCnh = txtRegCnh.Text;
            parte.Validade_cnh = dtpValidadeCnh.Text;
            parte.Categoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            parte.Cpf = txtCpf.Text;
            parte.Celular = txtCelular.Text;
            parte.Cep = txtCep.Text;
            parte.Complemento = txtComplemento.Text;
            parte.Local_Trabalho = txtLocalTrabalho.Text;
            parte.Numero_Trabalho = txtNumTrabalho.Text;
            parte.Bairro_Trabalho = txtBairroTrabalho.Text;
            parte.Cidade_Trabalho = txtCidadeTrabalho.Text;
            parte.Profissao = txtProfissao.Text;
            parte.Tel_Comercial = txtTelComercial.Text;
            parte.VersaoParte = txtVersao.Text;

            var resposta = MessageBox.Show("Deseja cadastrar uma nova parte para o mesmo B.O.?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                i += 1;
                addParte.Add(parte);
                LimparDadosParte();
            }
            else
            {
                grbPartes.Enabled = false;
               // LimparDadosParte();
            }
        }

        private void btnInformarApreensao_Click(object sender, EventArgs e)
        {
            frmApreensao novaApreensao = new frmApreensao(idBoletim);
            novaApreensao.ShowDialog();
        }

        private void btnAcidentes_Click(object sender, EventArgs e)
        {
            frmAcidentes novoAcidente = new frmAcidentes(idBoletim);
            novoAcidente.ShowDialog();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != String.Empty)
            {
                i += 1;
                parte = new Partes(txtNome.Text, txtNomePai.Text, txtNomeMae.Text, txtTelefone.Text, txtEndereco.Text, txtBairro.Text,
                    txtCidade.Text, txtNumero.Text, Convert.ToInt32(cmbEstado.SelectedValue), txtRg.Text, dtpDataNascimento.Text, Convert.ToInt32(cmbOrgaoEmissor.SelectedValue),
                    Convert.ToInt32(cmbOrgaoEmissorUf.SelectedValue), cmbTipoParte.Text, cmbConduzido.Text, txtNaturalidade.Text, txtNacionalidade.Text, idBoletim);

                parte.Emissao_Rg = dtpDataExpedicaoRg.Text;
                parte.Cnh = txtCnh.Text;
                parte.RegCnh = txtRegCnh.Text;
                parte.Validade_cnh = dtpValidadeCnh.Text;
                parte.Categoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                parte.Cpf = txtCpf.Text;
                parte.Celular = txtCelular.Text;
                parte.Cep = txtCep.Text;
                parte.Complemento = txtComplemento.Text;
                parte.Local_Trabalho = txtLocalTrabalho.Text;
                parte.Numero_Trabalho = txtNumTrabalho.Text;
                parte.Bairro_Trabalho = txtBairroTrabalho.Text;
                parte.Cidade_Trabalho = txtCidadeTrabalho.Text;
                parte.Profissao = txtProfissao.Text;
                parte.Tel_Comercial = txtTelComercial.Text;
                parte.VersaoParte = txtVersao.Text;
                parte.Naturalidade = txtNaturalidade.Text;
                addParte.Add(parte);
            }
            if (addParte.Count > 0)
            {
                _boletimOcorrenciaServices.CadastrarParte(addParte);
            }
            LimparDadosBO();
            LimparDadosParte();
            i = 0;
            idBoletim = 0;
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (txtCpf.Text != String.Empty)
            {
                _cpfServices = new CpfServices();
                if (!_cpfServices.Validacao(txtCpf.Text.Trim()))
                {
                    MessageBox.Show("CPF Inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCpf.Focus();
                }
                else
                {
                    RetornarParteCpf(txtCpf.Text.Trim());
                }
            }
           
        }

        private Boolean ValidarBoletim()
        {
            if (txtKmInicio.Text == String.Empty)
            {
                MessageBox.Show("Preencher o campo!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKmInicio.Focus();
                return false;
            }

            if (txtEnderecoOcorrencia.Text == String.Empty)
            {
                MessageBox.Show("Preencher o campo!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnderecoOcorrencia.Focus();
                return false;
            }

            if (txtKmFim.Text == String.Empty)
            {
                MessageBox.Show("Preencher o campo!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKmFim.Focus();
                return false;
            }

            if (cmbNatOcorrencia.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionar Natureza da Ocorrência!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbNatOcorrencia.Focus();
                return false;
            }

            if (cmbOcasiao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionar Situação", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbOcasiao.Focus();
                return false;
            }

            if (cmbPlantao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionar Plantão", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPlantao.Focus();
                return false;
            }

            if (cmbEquipe.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionar Equipe", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbEquipe.Focus();
                return false;
            }


            if (cmbViatura.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionar Viatura", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbViatura.Focus();
                return false;
            }

            if (cmbMotorista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionar Motorista", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMotorista.Focus();
                return false;
            }

            if (cmbEncarregado.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionar Encarregado", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbEncarregado.Focus();
                return false;
            }

            if (chkApoio.Checked)
            {
                if (cmbViaturaApoio.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecionar Viatura de apoio", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbViaturaApoio.Focus();
                    return false;
                }

                if (cmbMotoristaApoio.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecionar Motorista de apoio", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMotoristaApoio.Focus();
                    return false;
                }

                if (cmbEncarregadoApoio.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecionar Encarregado de apoio", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbEncarregadoApoio.Focus();
                    return false;
                }
            }

            grbPartes.Enabled = true;
            grbDados.Enabled = false;
            return true;
        }

        private Boolean ValidarParte()
        {
            if (txtNome.Text == String.Empty)
            {
                MessageBox.Show("Preencher o campo!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return false;
            }

            if (txtNomeMae.Text == String.Empty)
            {
                MessageBox.Show("Preencher o campo!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeMae.Focus();
                return false;
            }

            if (txtRg.Text == String.Empty)
            {
                MessageBox.Show("Preencher o campo!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRg.Focus();
                return false;
            }

            if (txtEndereco.Text == String.Empty)
            {
                MessageBox.Show("Preencher o campo!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Focus();
                return false;
            }

            if (txtCidade.Text == String.Empty)
            {
                MessageBox.Show("Preencher o campo!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCidade.Focus();
                return false;
            }

            if (txtBairro.Text == String.Empty)
            {
                MessageBox.Show("Preencher o campo!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBairro.Focus();
                return false;
            }

            if (cmbOrgaoEmissor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionar Orgão Emissor!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbOrgaoEmissor.Focus();
                return false;
            }

            if (cmbOrgaoEmissorUf.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionar Estado Orgão Emissor!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbOrgaoEmissorUf.Focus();
                return false;
            }
            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionar Categoria!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCategoria.Focus();
                return false;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionar Estado de residencia!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbEstado.Focus();
                return false;
            }
            return true;
        }

        private void RetornarIDBoletim()
        {
            dt = new DataTable();
            dt = _boletimOcorrenciaServices.RetornarIDBoletim();
            if (dt.Rows.Count > 0)
            {
                idBoletim = Convert.ToInt32(dt.Rows[0]["id"]);
            }
        }

        private void SalvarBoletim()
        {
            if (ValidarBoletim())
            {
                boletimOcorrencia = new BoletimOcorrencia(dtpDataOcorrencia.Text, dtpHoraInicio.Text, dtpSegHoraInicio.Text, dtpHoraTermino.Text,
                  dtpSegHoraTermino.Text, txtKmInicio.Text, txtSegKmInicio.Text, txtKmFim.Text, txtSegKmTermino.Text, cmbOcasiao.Text,
                  cmbNatOcorrencia.Text, txtBoPc.Text, Convert.ToInt32(cmbPlantao.SelectedValue), Convert.ToInt32(cmbEquipe.SelectedValue),
                  Convert.ToInt32(cmbViatura.SelectedValue), Convert.ToInt32(cmbMotorista.SelectedValue),
                  Convert.ToInt32(cmbEncarregado.SelectedValue), cmbAuxiliar.Text, txtEnderecoOcorrencia.Text);

                if (chkApoio.Checked == true)
                {
                    boletimOcorrencia.Viatura_Apoio = Convert.ToInt32(cmbViaturaApoio.SelectedValue);
                    boletimOcorrencia.MotoristaApoio = Convert.ToInt32(cmbMotoristaApoio.SelectedValue);
                    boletimOcorrencia.EncarregadoApoio = Convert.ToInt32(cmbEncarregadoApoio.SelectedValue);
                    boletimOcorrencia.AuxiliarApoio = cmbAuxiliarApoio.Text;

                    boletimOcorrencia.InstituicaoApoio = cmbApoio.Text;
                    boletimOcorrencia.MotoristaInstituicao = txtMotoristaApoio.Text.Trim();
                    boletimOcorrencia.EncarregadoInstituicao = txtEncarregadoApoio.Text.Trim();
                }

                _boletimOcorrenciaServices.CadastrarBoletimOcorrencia(boletimOcorrencia);
                RetornarIDBoletim();
            } 
        }

        private void RetornarParteCpf(string cpf)
        {
            _boletimOcorrenciaServices = new BLL.BoletimOcorrenciaServices();
            dt = new DataTable();
            dt = _boletimOcorrenciaServices.RetornarParteCpf(cpf);
            
            if (dt.Rows.Count != 0)
            {
                var resposta = MessageBox.Show("CPF já cadastrado! Carregar informações?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resposta == DialogResult.Yes)
                {
                    txtNome.Text = dt.Rows[0]["nome"].ToString();
                    txtNomePai.Text = dt.Rows[0]["nome_pai"].ToString();
                    txtNomeMae.Text = dt.Rows[0]["nome_mae"].ToString();
                    txtTelefone.Text = dt.Rows[0]["telefone"].ToString();
                    txtCelular.Text = dt.Rows[0]["celular"].ToString();
                    txtEndereco.Text = dt.Rows[0]["endereco"].ToString();
                    txtCidade.Text = dt.Rows[0]["cidade"].ToString();
                    txtBairro.Text = dt.Rows[0]["bairro"].ToString();
                    txtNumero.Text = dt.Rows[0]["numero"].ToString();
                    cmbEstado.SelectedValue = Convert.ToInt16(dt.Rows[0]["estado"]);
                    txtCep.Text = dt.Rows[0]["cep"].ToString();
                    txtComplemento.Text = dt.Rows[0]["complemento"].ToString();
                    txtNaturalidade.Text = dt.Rows[0]["naturalidade"].ToString();
                    txtNacionalidade.Text = dt.Rows[0]["nacionalidade"].ToString();
                    txtLocalTrabalho.Text = dt.Rows[0]["local_trabalho"].ToString();
                    txtNumTrabalho.Text = dt.Rows[0]["num_trabalho"].ToString();
                    txtBairroTrabalho.Text = dt.Rows[0]["bairro_trabalho"].ToString();
                    txtCidadeTrabalho.Text = dt.Rows[0]["cidade_trabalho"].ToString();
                    txtProfissao.Text = dt.Rows[0]["profissao"].ToString();
                    txtTelComercial.Text = dt.Rows[0]["tel_comercial"].ToString();
                    dtpDataNascimento.Value = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                    txtCpf.Text = dt.Rows[0]["cpf"].ToString();
                    txtRg.Text = dt.Rows[0]["rg"].ToString();
                    dtpDataExpedicaoRg.Value = Convert.ToDateTime(dt.Rows[0]["expedicao_rg"]);
                    cmbOrgaoEmissor.SelectedValue = Convert.ToInt16(dt.Rows[0]["org_emissor"]);
                    cmbOrgaoEmissorUf.SelectedValue = Convert.ToInt16(dt.Rows[0]["uf"]);
                    cmbCategoria.SelectedValue = Convert.ToInt16(dt.Rows[0]["categoria"]);
                    txtRegCnh.Text = dt.Rows[0]["reg_cnh"].ToString();
                    txtCnh.Text = dt.Rows[0]["num_cnh"].ToString();
                    dtpValidadeCnh.Value = Convert.ToDateTime(dt.Rows[0]["val_cnh"]);
                    txtNaturalidade.Text = dt.Rows[0]["naturalidade"].ToString();
                }
            }
        }

        private void ValidarEquipes()
        {
            if (cmbMotorista.Text == cmbMotoristaApoio.Text)
            {
                MessageBox.Show("Impossivel Salvar!");
                cmbMotoristaApoio.Focus();
            }

            else if (cmbEncarregado.Text == cmbEncarregadoApoio.Text)
            {
                MessageBox.Show("Impossivel Salvar!");
                cmbEncarregadoApoio.Focus();
            }
        }

        private void CarregarComboBox()
        {
            _boletimOcorrenciaServices = new BoletimOcorrenciaServices();
            cmbCategoria.DataSource = _boletimOcorrenciaServices.CarregarCategoria();
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id";
            cmbCategoria.SelectedIndex = -1;

            cmbEstado.DataSource = _boletimOcorrenciaServices.CarregarEstado();
            cmbEstado.DisplayMember = "sigla";
            cmbEstado.ValueMember = "id";
            cmbEstado.SelectedIndex = -1;

            cmbOrgaoEmissorUf.DataSource = _boletimOcorrenciaServices.CarregarEstado();
            cmbOrgaoEmissorUf.DisplayMember = "sigla";
            cmbOrgaoEmissorUf.ValueMember = "id";
            cmbOrgaoEmissorUf.SelectedIndex = -1;

            cmbOrgaoEmissor.DataSource = _boletimOcorrenciaServices.CarregarOrgEmissor();
            cmbOrgaoEmissor.DisplayMember = "sigla";
            cmbOrgaoEmissor.ValueMember = "id";
            cmbOrgaoEmissor.SelectedIndex = -1;

            cmbNatOcorrencia.DataSource = _boletimOcorrenciaServices.CarregarNatOcorrencia();
            cmbNatOcorrencia.DisplayMember = "nome";
            cmbNatOcorrencia.ValueMember = "id";
            cmbNatOcorrencia.SelectedIndex = -1;

            cmbViatura.DataSource = _boletimOcorrenciaServices.CarregarViatura();
            cmbViatura.DisplayMember = "prefixo";
            cmbViatura.ValueMember = "id_veiculo";
            cmbViatura.SelectedIndex = -1;

            cmbViaturaApoio.DataSource = _boletimOcorrenciaServices.CarregarViatura();
            cmbViaturaApoio.DisplayMember = "prefixo";
            cmbViaturaApoio.ValueMember = "id_veiculo";
            cmbViaturaApoio.SelectedIndex = -1;

            cmbEquipe.DataSource = _boletimOcorrenciaServices.CarregarEquipe();
            cmbEquipe.DisplayMember = "nome_equipe";
            cmbEquipe.ValueMember = "id";
            cmbEquipe.SelectedIndex = -1;

            cmbPlantao.DataSource = _boletimOcorrenciaServices.CarregarPlantao();
            cmbPlantao.DisplayMember = "nome_plantao";
            cmbPlantao.ValueMember = "id";
            cmbPlantao.SelectedIndex = -1;

        }

        private void LimparDadosBO()
        {
            i = 0;
            dtpDataOcorrencia.Value = DateTime.Now;
            dtpHoraInicio.Value = DateTime.Now;
            dtpHoraTermino.Value = DateTime.Now;
            dtpSegHoraInicio.Value = DateTime.Now;
            dtpSegHoraTermino.Value = DateTime.Now;

            cmbNatOcorrencia.SelectedIndex = -1;
            cmbOcasiao.SelectedIndex = -1;
            cmbMotorista.SelectedIndex = -1;
            cmbEncarregado.SelectedIndex = -1;
            cmbAuxiliar.SelectedIndex = -1;
            cmbPlantao.SelectedIndex = -1;
            cmbEquipe.SelectedIndex = -1;
            cmbViatura.SelectedIndex = -1;
            cmbMotoristaApoio.SelectedIndex = -1;
            cmbEncarregadoApoio.SelectedIndex = -1;
            cmbAuxiliarApoio.SelectedIndex = -1;
            cmbViaturaApoio.SelectedIndex = -1;
            cmbApoio.SelectedIndex = -1;

            chkApoio.Checked = false;

            txtBoPc.Text = String.Empty;
            txtKmInicio.Text = String.Empty;
            txtKmFim.Text = String.Empty;
            txtSegKmInicio.Text = String.Empty;
            txtSegKmTermino.Text = String.Empty;
            txtMotoristaApoio.Text = String.Empty;
            txtEncarregadoApoio.Text = String.Empty;

            grbDados.Enabled = true;
            grbPartes.Enabled = false;
            btnAcidentes.Enabled = false;
            btnInformarApreensao.Enabled = false;
            btnFinalizar.Enabled = false;
        }

        private void LimparDadosParte()
        {
            txtCpf.Text = String.Empty;
            txtRg.Text = String.Empty;
            txtCnh.Text = String.Empty;
            txtRegCnh.Text = String.Empty;
            txtNome.Text = String.Empty; ;
            txtEndereco.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtCep.Text = String.Empty;
            txtNomePai.Text = String.Empty;
            txtNomeMae.Text = String.Empty;
            txtComplemento.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtTelComercial.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtNaturalidade.Text = String.Empty;
            txtNacionalidade.Text = String.Empty;
            txtLocalTrabalho.Text = String.Empty;
            txtNumTrabalho.Text = String.Empty;
            txtBairroTrabalho.Text = String.Empty;
            txtCidadeTrabalho.Text = String.Empty;
            txtProfissao.Text = String.Empty;
            txtVersao.Text = String.Empty;

            dtpDataNascimento.Value = DateTime.Now;
            dtpDataExpedicaoRg.Value = DateTime.Now;
            dtpValidadeCnh.Value = DateTime.Now;

            cmbOrgaoEmissor.SelectedIndex = -1;
            cmbOrgaoEmissorUf.SelectedIndex = -1;
            cmbTipoParte.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            cmbConduzido.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }

        private void CarregarMotorista(int plantao, int equipe)
        {
            if (cmbPlantao.SelectedIndex != -1 && cmbEquipe.SelectedIndex != -1)
            {
                cmbMotorista.Enabled = true;
                cmbEncarregado.Enabled = true;
                _boletimOcorrenciaServices = new BLL.BoletimOcorrenciaServices();
                cmbMotorista.DataSource = _boletimOcorrenciaServices.CarregarMotorista(plantao, equipe);
                cmbMotorista.DisplayMember = "qra";
                cmbMotorista.ValueMember = "id";
                cmbMotorista.SelectedIndex = -1;

                cmbMotoristaApoio.DataSource = _boletimOcorrenciaServices.CarregarMotorista(plantao, equipe);
                cmbMotoristaApoio.DisplayMember = "qra";
                cmbMotoristaApoio.ValueMember = "id";
                cmbMotoristaApoio.SelectedIndex = -1;
            }
        }

        private void CarregarEncarregado(int plantao, int equipe)
        {
            cmbMotorista.Enabled = true;
            cmbEncarregado.Enabled = true;
            _boletimOcorrenciaServices = new BLL.BoletimOcorrenciaServices();
            cmbEncarregado.DataSource = _boletimOcorrenciaServices.CarregarEncarregado(plantao, equipe);
            cmbEncarregado.DisplayMember = "qra";
            cmbEncarregado.ValueMember = "id";
            cmbEncarregado.SelectedIndex = -1;

            cmbEncarregadoApoio.DataSource = _boletimOcorrenciaServices.CarregarEncarregado(plantao, equipe);
            cmbEncarregadoApoio.DisplayMember = "qra";
            cmbEncarregadoApoio.ValueMember = "id";
            cmbEncarregadoApoio.SelectedIndex = -1;
        }

        private void CarregarAuxiliar(int plantao, int equipe)
        {
            cmbMotorista.Enabled = true;
            cmbEncarregado.Enabled = true;
            cmbAuxiliar.Enabled = true;
            _boletimOcorrenciaServices = new BLL.BoletimOcorrenciaServices();
            cmbAuxiliar.DataSource = _boletimOcorrenciaServices.CarregarAuxiliar(plantao, equipe);
            cmbAuxiliar.DisplayMember = "qra";
            cmbAuxiliar.ValueMember = "id";
            cmbAuxiliar.SelectedIndex = -1;

            cmbAuxiliarApoio.DataSource = _boletimOcorrenciaServices.CarregarAuxiliar(plantao, equipe);
            cmbAuxiliarApoio.DisplayMember = "qra";
            cmbAuxiliarApoio.ValueMember = "id";
            cmbAuxiliarApoio.SelectedIndex = -1;
        }

        private void cmbMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMotorista.SelectedIndex != -1)
            {
                drv = ((DataRowView)cmbMotorista.SelectedItem);
                lblRfMotorista.Text = drv["reg_funcional"].ToString();
            }
            else
                lblRfMotorista.Text = "";
        }

        private void cmbEncarregado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEncarregado.SelectedIndex != -1 && cmbMotorista.SelectedIndex != -1)
            {
                drv = ((DataRowView)cmbEncarregado.SelectedItem);
                lblRfEncarregado.Text = drv["reg_funcional"].ToString();
            }
            else
                lblRfEncarregado.Text = "";
        }

        private void cmbAuxiliar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuxiliar.SelectedIndex != -1)
            {
                drv = ((DataRowView)cmbAuxiliar.SelectedItem);
                lblRfAuxiliar.Text = drv["reg_funcional"].ToString();
            }
            else
                lblRfAuxiliar.Text = "";
        }

        private void btnLimparPartes_Click(object sender, EventArgs e)
        {
            i = 0;
            LimparDadosParte();
        }

        private void chkApoio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApoio.Checked == true)
                grbApoioGcm.Enabled = true;
            
            else
                grbApoioGcm.Enabled = false;
        }

        private void cmbViaturaApoio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbViaturaApoio.SelectedIndex != -1)
            {
                cmbMotoristaApoio.Enabled = true;
                cmbEncarregadoApoio.Enabled = true;
                cmbAuxiliarApoio.Enabled = true;
            }

            else
            {
                cmbMotoristaApoio.Enabled = false;
                cmbEncarregadoApoio.Enabled = false;
                cmbAuxiliarApoio.Enabled = false;
            }
        }

        private void btnLimparDados_Click_1(object sender, EventArgs e)
        {
            LimparDadosBO();
        }

        
        private void btnIniciarBo_Click_1(object sender, EventArgs e)
        {
            SalvarBoletim();
            btnInformarApreensao.Enabled = true;
            btnFinalizar.Enabled = true;

            if (cmbNatOcorrencia.Text == "Acidente de transito")
                btnAcidentes.Enabled = true;

            else
                btnAcidentes.Enabled = false;
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
            if (cmbPlantao.SelectedIndex != -1)
            {
                drv = ((DataRowView)cmbPlantao.SelectedItem);
                equipe = Convert.ToInt16(drv["id"]);
                CarregarMotorista(plantao, equipe);
                CarregarEncarregado(plantao, equipe);
            }
        }
    }
}
