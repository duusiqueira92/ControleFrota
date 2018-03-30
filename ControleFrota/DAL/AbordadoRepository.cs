using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace DAL
{
    public class AbordadoRepository : IAbordadoRepository
    {
        DataBaseAcess db;
        DataTable dt;

        public void CadastrarAbordado(Abordado abordado)
        {
            db = new DataBaseAcess();
            db.Conectar();
            string comando = @"INSERT INTO abordados(nome, rg, endereco, passagem, artigo, equipe)
                                 VALUES('" + abordado.Nome_Abordado + "', '" + abordado.Rg + "', '" + abordado.Endereco + "', '" + abordado.Passagem + "', '"
                                 + abordado.Artigo + "', '" + abordado.Equipe + "')";
            db.ExecutarComandoSql(comando);
        }

        public DataTable CarregarAbordados(int equipe)
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            string comando = "SELECT * FROM abordados WHERE equipe = " + equipe;
            try
            {
                db.Conectar();
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
