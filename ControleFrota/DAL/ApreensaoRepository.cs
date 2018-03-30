using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class ApreensaoRepository : IApreensoesRepository
    {
        DataBaseAcess db;
        DataTable dt;

        public void CadastrarApreensao(List<Apreensao> objetos)
        {
            try
            {
                db = new DataBaseAcess();
                for (int i = 0; i < objetos.Count; i++)
                {
                    string comando = @"INSERT INTO apreensao(modelo, marca, categoria_objeto, num_objeto, cor, quantidade,
                                  observações, boletim_ocorrencia) 
                                  VALUES('" + objetos[i].ModeloObjeto + "', '" + objetos[i].Marca + "', '" + objetos[i].CategoriaObjeto + "', '"
                                  + objetos[i].NumObjeto + "', '" + objetos[i].CorObjeto + "', '" + objetos[i].Quantidade + "', '" + objetos[i].Observacoes + "', '"
                                  + objetos[i].IdBoletim + "')";

                    db.Conectar();
                    db.ExecutarComandoSql(comando);
                }
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

        public DataTable RetornarObjetos()
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                string comando = "SELECT * FROM categoria_objeto ORDER BY nome";
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
