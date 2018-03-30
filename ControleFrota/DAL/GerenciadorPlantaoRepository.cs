using DAL.Interfaces;
using System;
using System.Data;

namespace DAL
{
    public class GerenciadorPlantaoRepository : IGerenciadorPlantaoRepository
    {
        DataBaseAcess db;
        DataTable dt;

        public void AlterarPlantao(int id, int plantao, int equipe, int posicao)
        {
            db = new DataBaseAcess();
            try
            {
                db.Conectar();
                string comando = @"UPDATE agentes SET plantao = '" + plantao + "', equipe = '" + equipe + "', posicao = '" + posicao + "' WHERE id = '" + id + "'";
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

        public DataTable CarregarAgentes()
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = @"SELECT a.id as id_agente, a.qra AS QRA, p.nome_plantao AS Plantão, e.nome_equipe AS Equipe, ps.posicao AS Posição, 
                                p.id AS PID, e.id AS EID, ps.id AS PSID FROM agentes a
                                INNER JOIN plantao p ON a.plantao = p.id
                                INNER JOIN equipe e ON a.equipe = e.id
                                INNER JOIN posicao ps ON a.posicao = ps.id ORDER BY QRA";
                dt = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db = null;
            }
            return dt;
        }

        public DataTable CarregarEquipe()
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = "SELECT * FROM equipe";
                dt = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db = null;
            }
            return dt;
        }

        public DataTable CarregarPlantao()
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = "SELECT * FROM plantao";
                dt = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db = null;
            }
            return dt;
        }

        public DataTable CarregarPosicao()
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = "SELECT * FROM posicao";
                dt = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db = null;
            }
            return dt;
        }
    }
}
