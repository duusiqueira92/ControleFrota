using BLL;
using BLL.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class frmAgentePlantao : Form
    {

        IFuncionarioServices _funcionarioServices;
        int id;

        public frmAgentePlantao(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmAgentePlantao_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
        }

        private void CarregarComboBox()
        {
            _funcionarioServices = new FuncionarioServices();
            cmbPlantao.DataSource = _funcionarioServices.CarregarPlantao();
            cmbPlantao.DisplayMember = "nome_plantao";
            cmbPlantao.ValueMember = "id";
            cmbPlantao.SelectedValue = -1;

            cmbEquipe.DataSource = _funcionarioServices.CarregarEquipe();
            cmbEquipe.DisplayMember = "nome_equipe";
            cmbEquipe.ValueMember = "id";
            cmbEquipe.SelectedValue = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _funcionarioServices = new FuncionarioServices();

            MessageBox.Show(_funcionarioServices.AlterarPlantao(Convert.ToInt16(cmbPlantao.SelectedValue), Convert.ToInt16(cmbEquipe.SelectedValue), id));
            this.Close();
        }
    }
}
