using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class GraduacaoRepository : IGraduacaoRepository
    {
        DataBaseAcess db;
        public void CadastrarGraduacao(Graduacao graduacao)
        {
            try
            {
                db = new DataBaseAcess();
                db.Conectar();
                string comando = @"INSERT INTO graduacao(graduacao, descricao)
                                VALUES ('" + graduacao.Nome_graduacao + "', '" + graduacao.Descricao + "')";
                db.ExecutarComandoSql(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao CADASTRAR Graduação! " + ex.Message, "Erro");
            }
        }

        public DataTable CarregarGraduacao(Graduacao graduacao)
        {
            DataTable dt = new DataTable();
            try
            {
                db = new DataBaseAcess();
                db.Conectar();
                dt = db.RetDataTable("SELECT id, graduacao FROM graduacao");
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
            finally
            {
                db = null;
            }
            return dt;
        }
    }
}
