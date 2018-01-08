using System.Windows.Forms;

namespace BLL
{
    public class ArmamentoBLL
    {
        public void salvarArma(int id, string nome, string modelo, string numero)
        {
            if (id == 0)
            {
                MessageBox.Show("Test");
            }
        }
    }
}
