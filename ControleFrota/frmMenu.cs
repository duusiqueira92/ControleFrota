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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            
        }

        private void btnBoletimOcorrencia_Click(object sender, EventArgs e)
        {
            frmInformarEquipes infoEquipe = new frmInformarEquipes();
            infoEquipe.ShowDialog();
        }

        private void btnGuardas_Click(object sender, EventArgs e)
        {
            frmCadastrarGuardas cadGcm = new frmCadastrarGuardas();
            cadGcm.ShowDialog();
        }
    }
}
