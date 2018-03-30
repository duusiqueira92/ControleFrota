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
    public partial class frmCadastrarObjeto : Form
    {
        Objeto objeto;
        ObjetoServices objetoServices;
        IObjetoRepository _objetoRepository; 

        public frmCadastrarObjeto()
        {
            InitializeComponent();
        }

        private void CadastrarObjeto()
        {
            objeto = new Objeto();
            objeto.NomeObjeto = txtNomeObjeto.Text.Trim();
            objetoServices = new ObjetoServices(_objetoRepository);
            objetoServices.CadastrarObjeto(objeto);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarObjeto();
        }
    }
}
