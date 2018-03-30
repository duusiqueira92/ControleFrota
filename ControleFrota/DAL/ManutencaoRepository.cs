using System;
using DAL.Interfaces;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ManutencaoRepository : IManutencaoRespository
    {

        DataBaseAcess db;
        DataTable dt;
        public void CadastrarManutencao(Manutencao manutencao)
        {
            try
            {
                db = new DataBaseAcess();
                db.Conectar();
                string comando = @"INSERT INTO manutencao(veiculo, km_oleo, km_f_oleo, km_f_combustivel, km_pte, km_ptd, 
                                  km_pde, km_pdd, lampadas, lataria, equipamentos, motor, data_manutencao) 
                                  VALUES('" + manutencao.Veiculo + "', '" + manutencao.Km_Oleo + "', '" + manutencao.Km_F_Oleo + "', '"
                                  + manutencao.Km_F_Combustivel + "', '" + manutencao.Km_Pte + "', '" + manutencao.Km_Ptd + "', '"
                                  + manutencao.Km_Pde + "', '" + manutencao.Km_Pdd + "', '" + manutencao.Lampadas + "', '"
                                  + manutencao.Lataria + "', '" + manutencao.Equipamento + "', '" + manutencao.Motor + "', '"
                                  + manutencao.Data_Manutencao + "')";
                db.ExecutarComandoSql(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db = null;
            }
        }

        public DataTable CarregarManutencao(int id_viatura)
        {
            dt = new DataTable();
            db = new DataBaseAcess();
            try
            {
                db.Conectar();
                string comando = "SELECT * FROM manutencao WHERE veiculo = " + id_viatura + " order by id_manutencao desc ";
                dt = db.RetDataTable(comando);
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }
    }
}
