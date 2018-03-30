using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DataBaseAcess
    {
        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlCommandBuilder cb;

        private string server = "localhost";
        private string user = "root";
        private string password = "SyNc+ter1992";
        private string database = "controlegcm";

        public void Conectar()
        {
            if (conn != null)
                conn.Close();

            string connStr = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false; SslMode=none", server, user, password, database);

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Falha ao conectar com o banco de dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ExecutarComandoSql(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            comando.ExecuteReader();
            conn.Close();
        }

        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }

        public MySqlDataReader RetDataReader(string sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            Abordado abordado = new Abordado();
            while (dr.Read())
            {
                return dr;
            }
            return dr;
        }
    }
}
